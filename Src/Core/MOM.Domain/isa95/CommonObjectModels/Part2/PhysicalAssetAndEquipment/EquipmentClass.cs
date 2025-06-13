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
        /// �ڻ��ڽ�ɫ��װ������м���ı�ʶ
        /// </summary>
        [JsonPropertyName("equipmentLevel")]
        public EquipmentClassEquipmentLevel? EquipmentLevel { get; set; }

        /// <summary>
        /// ��ǰ����������ӷ��ࡣ<br/>
        /// ���ӹ�ϵ����Ҫ����������ࡢһ���ࡢ�����ࡢ�����ࡢ�����ࡢ������ȣ�<br/>
        /// �豸->��Ҫ�豸->�����豸<br/>
        /// �豸->��Ҫ�豸->�����豸<br/>
        /// �豸->����->��װ����
        /// </summary>
        [JsonIgnore]
        public virtual List<EquipmentClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<EquipmentClassIncludesPropertiesOfRelationship>();

        /// <summary>
        /// ������豸�������豸������塣<br/>
        /// ��ɹ�ϵ��������豸����練Ӧ����ѹ������CNC���泵���г��ȣ�<br/>
        /// ��װ����->A���豸<br/>
        /// ��װ����->B���豸<br/>
        /// A���豸��B���豸��ͬ��ɹ�װ����
        /// </summary>
        [JsonIgnore]
        public virtual List<EquipmentClassIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentClassIsMadeUpOfRelationship>();

        /// <summary>
        /// ��չ����
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