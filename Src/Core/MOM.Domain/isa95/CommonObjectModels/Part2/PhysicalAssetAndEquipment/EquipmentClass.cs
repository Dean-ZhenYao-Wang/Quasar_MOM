namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.EquipmentClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public partial class EquipmentClass : ResourceClass, IEquatable<EquipmentClass>
    {
        public EquipmentClass()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentClass;1";

        [JsonPropertyName("hierarchyScope")]
        public string HierarchyScope => HierarchyScopeRel.FirstOrDefault() == null ? string.Empty : HierarchyScopeRel.FirstOrDefault().Target.Id.ToString();

        /// <summary>
        /// 在基于角色的装备层次中级别的标识
        /// </summary>
        [JsonPropertyName("equipmentLevel")]
        public EquipmentClassEquipmentLevel? EquipmentLevel { get; set; }

        /// <summary>
        /// 当前分类包含的子分类。<br/>
        /// 父子关系（主要类别，如生产类、一起类、辅助类、工具类、运输类、管理类等）<br/>
        /// 设备->主要设备->甲类设备<br/>
        /// 设备->主要设备->乙类设备<br/>
        /// 设备->产线->罐装产线
        /// </summary>
        [JsonIgnore]
        public virtual List<EquipmentClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<EquipmentClassIncludesPropertiesOfRelationship>();

        /// <summary>
        /// 这个父设备类是子设备类的整体。<br/>
        /// 组成关系（具体的设备类别，如反应器、压缩机、CNC、叉车、行车等）<br/>
        /// 罐装产线->A类设备<br/>
        /// 罐装产线->B类设备<br/>
        /// A类设备与B类设备共同组成罐装产线
        /// </summary>
        [JsonIgnore]
        public virtual List<EquipmentClassIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentClassIsMadeUpOfRelationship>();

        /// <summary>
        /// 扩展属性
        /// </summary>
        public virtual EquipmentClassProperty Property { get; set; } = new EquipmentClassProperty();

        [JsonIgnore]
        [MaxLength(1)]
        public virtual List<EquipmentClassHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<EquipmentClassHierarchyScopeRelRelationship>();



        public string Description { get; set; }

        public EquipmentClass(string ID, string description) : this()
        {
            this.Id = Id;
            this.Description = description;
        }

        public async void PutIncludesPropertiesOf(List<Guid> childClassDtId)
        {
            var haveDtIds = this.IncludesPropertiesOf.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childClassDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childClassDtId);
            foreach (var item in deleteDtIds)
            {
                this.IncludesPropertiesOf.RemoveAll(m => m.TargetId == item);
            }
            foreach (var item in notHaveDtIds)
            {
                this.IncludesPropertiesOf.Add(new Common.Relationship.isa95.EquipmentClass.EquipmentClassIncludesPropertiesOfRelationship(this.DtId, item));
            }
        }

        public async void PutIsMadeUpOf(List<Guid> childClassDtId)
        {
            var haveDtIds = this.IsMadeUpOf.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childClassDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childClassDtId);
            foreach (var item in deleteDtIds)
            {
                this.IsMadeUpOf.RemoveAll(m => m.TargetId == item);
            }
            foreach (var item in notHaveDtIds)
            {
                this.IsMadeUpOf.Add(new Common.Relationship.isa95.EquipmentClass.EquipmentClassIsMadeUpOfRelationship(this.DtId, item));
            }
        }

        public void Update(string iD, string? description, EquipmentClassEquipmentLevel? equipmentLevel)
        {
            this.Id = Id;
            this.Description = description;
            this.EquipmentLevel = equipmentLevel;
        }

        public void Delete()
        {
            this.HierarchyScopeRel.Clear();
            this.IncludesPropertiesOf.Clear();
            this.IsDelete = true;
        }




        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClass);
        }

        public bool Equals(EquipmentClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && EquipmentLevel == other.EquipmentLevel;
        }

        public static bool operator ==(EquipmentClass? left, EquipmentClass? right)
        {
            return EqualityComparer<EquipmentClass?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentClass? left, EquipmentClass? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), EquipmentLevel?.GetHashCode());
        }
    }
}