using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.MaterialClass;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    public partial class MaterialClass
    {
        public string Description { get; set; }

        public MaterialClass(string ID, string description = "", HierarchyScope? hierarchyScope = null, MaterialClassAssemblyType? assemblyType = null, MaterialClassAssemblyRelationship? assemblyRelationship = null) : this()
        {
            this.Id = Id;
            this.Description = description;
            if (hierarchyScope != null)
            {
                this.HierarchyScopeRelAddTarget(hierarchyScope);
            }
            if (assemblyType != null)
                this.AssemblyType = assemblyType;
            if (assemblyRelationship != null)
                this.AssemblyRelationship = assemblyRelationship;
        }

        public void HierarchyScopeRelAddTarget(HierarchyScope target)
        {
            this.HierarchyScope = target.Id;
            this.HierarchyScopeRel.Add(new MaterialClassHierarchyScopeRelRelationship(this, target));
        }

        public void HasPropertiesOfAddTarget(MaterialClassProperty target)
        {
            this.HasPropertiesOf.Add(new MaterialClassHasPropertiesOfRelationship(this, target));
        }

        public void IsAssembledFromAddTarget(MaterialClass target)
        {
            this.IsAssembledFrom.Add(new MaterialClassIsAssembledFromRelationship(this, target));
        }

        public void IsAssembledFromAddTarget(string targetId)
        {
            this.IsAssembledFrom.Add(new MaterialClassIsAssembledFromRelationship(this.DtId, targetId));
        }

        public void IncludesPropertiesOfAddTarget(MaterialClass target)
        {
            this.IncludesPropertiesOf.Add(new MaterialClassIncludesPropertiesOfRelationship(this, target));
        }

        public void IncludesPropertiesOfAddTarget(string targetId)
        {
            this.IncludesPropertiesOf.Add(new MaterialClassIncludesPropertiesOfRelationship(this.DtId, targetId));
        }

        public void Delete()
        {
            foreach (var property in HasPropertiesOf)
            {
                property.Target.Delete();
            }
            this.IsDelete = true;
            foreach (var item in IncludesPropertiesOf.Where(m => m.Target.IsDelete == false))
            {
                item.Target.Delete();
            }
            this.HierarchyScopeRel.Clear();
            this.IsAssembledFrom.Clear();
        }

        public void Update(string iD, string description, MaterialClassAssemblyType? assemblyType, MaterialClassAssemblyRelationship? assemblyRelationship)
        {
            this.Id = Id;
            this.Description = description;
            this.AssemblyType = assemblyType;
            this.AssemblyRelationship = assemblyRelationship;
        }

        public void Update(string iD, string description, HierarchyScope hierarchyScope, MaterialClassAssemblyType? assemblyType, MaterialClassAssemblyRelationship? assemblyRelationship)
        {
            this.Update(iD, description, assemblyType, assemblyRelationship);
            this.HierarchyScopeRelAddTarget(hierarchyScope);
        }

        public List<string> GetHaveChildClassDtIdList()
        {
            return this.IncludesPropertiesOf.Targets.Where(m => m.IsDelete == false).Select(m => m.DtId).ToList();
        }

        public void IncludesPropertiesOfRemoveTargets(IEnumerable<string> childDtIds)
        {
            this.IncludesPropertiesOf.Remove(childDtIds);
        }

        public void IsAssembledFromRemoveTargets(IEnumerable<string> deleteDtIds)
        {
            this.IsAssembledFrom.Remove(deleteDtIds);
        }
    }
}