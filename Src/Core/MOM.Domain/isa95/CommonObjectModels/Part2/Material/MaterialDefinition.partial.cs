using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.MaterialDefinition;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    public partial class MaterialDefinition
    {
        public string Description { get; set; }
        /// <summary>
        /// 物料编码
        /// </summary>
        [Required]
        [JsonPropertyName("number")]
        public string Number { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        [Required]
        [JsonPropertyName("specification")]
        public string Specification { get; set; }
        /// <summary>
        /// 材质
        /// </summary>
        [JsonPropertyName("texture")]
        public string? Texture { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        [Required]
        [JsonPropertyName("modelNumber")]
        public string ModelNumber { get; set; }
        /// <summary>
        /// 重量
        /// </summary>
        [JsonPropertyName("weight")]
        public double? Weight { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        [JsonPropertyName("unitPrice")]
        public decimal? UnitPrice { get; set; }
        /// <summary>
        /// 计量单位
        /// </summary>
        [Required]
        [JsonPropertyName("unitOfMeasurement")]
        public string UnitOfMeasurement { get; set; }

        public MaterialDefinition(string ID, string description = "", HierarchyScope? hierarchyScope = null, MaterialDefinitionAssemblyType? assemblyType = null, MaterialDefinitionAssemblyRelationship? assemblyRelationship = null, string number = null, string specification = null, string? texture = null, string modelNumber = null, double? weight = null, decimal? unitPrice = null, string unitOfMeasurement = null) : this()
        {
            this.Id = Id;
            this.Description = description;
            if (hierarchyScope != null)
            {
                this.HierarchyScopeRelAddTarget(hierarchyScope);
            }
            this.AssemblyType = assemblyType;
            this.AssemblyRelationship = assemblyRelationship;
            Number = number;
            Specification = specification;
            Texture = texture;
            ModelNumber = modelNumber;
            Weight = weight;
            UnitPrice = unitPrice;
            UnitOfMeasurement = unitOfMeasurement;
        }

        private void HierarchyScopeRelAddTarget(HierarchyScope hierarchyScope)
        {
            this.HierarchyScope = hierarchyScope.Id;
            this.HierarchyScopeRel.Add(new MaterialDefinitionHierarchyScopeRelRelationship(this, hierarchyScope));
        }

        public void HasPropertiesOfAddTarget(MaterialDefinitionProperty target)
        {
            this.HasPropertiesOf.Add(new MaterialDefinitionHasPropertiesOfRelationship(this, target));
        }

        public void HasPropertiesOfAddTarget(Guid targetDtId)
        {
            this.HasPropertiesOf.Add(new MaterialDefinitionHasPropertiesOfRelationship(this.DtId, targetDtId));
        }

        public void IsMemberOfClassAddTarget(MaterialClass target)
        {
            this.IsMemberOfClass.Add(new MaterialDefinitionIsMemberOfClassRelationship(this, target));
        }

        public void IsMemberOfClassAddTarget(Guid materialClassDtId)
        {
            this.IsMemberOfClass.Add(new MaterialDefinitionIsMemberOfClassRelationship(this.DtId, materialClassDtId));
        }

        public void IsMemberOfClassAddTarget(List<MaterialClass> materialClasses)
        {
            foreach (var item in materialClasses)
            {
                this.IsMemberOfClassAddTarget(item);
            }
        }

        public void IsAssembledFromAddTarget(MaterialDefinition target)
        {
            this.IsAssembledFrom.Add(new MaterialDefinitionIsAssembledFromRelationship(this, target));
        }

        public void IsAssembledFromAddTarget(Guid targetDtId)
        {
            this.IsAssembledFrom.Add(new MaterialDefinitionIsAssembledFromRelationship(this.DtId, targetDtId));
        }

        public void IsAssembledFromAddTarget(IEnumerable<Guid> targetDtIds)
        {
            foreach (var targetDtId in targetDtIds)
            {
                this.IsAssembledFrom.Add(new MaterialDefinitionIsAssembledFromRelationship(this.DtId, targetDtId));
            }
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.HierarchyScopeRel.Clear();
            this.IsMemberOfClass.Clear();
            this.IsAssembledFrom.Clear();
            foreach (var item in HasPropertiesOf.Where(m => m.Target.IsDelete == false))
            {
                item.Target.Delete();
            }
        }

        public void Update(string iD, string description, MaterialDefinitionAssemblyType? assemblyType, MaterialDefinitionAssemblyRelationship? assemblyRelationship)
        {
            this.Id = Id;
            this.Description = description;
            this.AssemblyType = assemblyType;
            this.AssemblyRelationship = assemblyRelationship;
        }

        public void Update(string iD, string description, HierarchyScope hierarchyScope, MaterialDefinitionAssemblyType? assemblyType, MaterialDefinitionAssemblyRelationship? assemblyRelationship)
        {
            this.Update(iD, description, assemblyType, assemblyRelationship);
            this.HierarchyScopeRelAddTarget(hierarchyScope);
        }
    }
}