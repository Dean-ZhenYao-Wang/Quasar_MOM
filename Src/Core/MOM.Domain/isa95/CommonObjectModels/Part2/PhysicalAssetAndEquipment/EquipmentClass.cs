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
        public string HierarchyScope => HierarchyScopeRel.FirstOrDefault() == null ? string.Empty : HierarchyScopeRel.FirstOrDefault().Target.Id;

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
        public virtual EquipmentClassIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new EquipmentClassIncludesPropertiesOfRelationshipCollection();

        /// <summary>
        /// ������豸�������豸������塣<br/>
        /// ��ɹ�ϵ��������豸����練Ӧ����ѹ������CNC���泵���г��ȣ�<br/>
        /// ��װ����->A���豸<br/>
        /// ��װ����->B���豸<br/>
        /// A���豸��B���豸��ͬ��ɹ�װ����
        /// </summary>
        [JsonIgnore]
        public virtual EquipmentClassIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new EquipmentClassIsMadeUpOfRelationshipCollection();

        /// <summary>
        /// �Զ��������嵥
        /// </summary>
        [JsonIgnore]
        public virtual EquipmentClassHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new EquipmentClassHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        [MaxLength(1)]
        public virtual EquipmentClassHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new EquipmentClassHierarchyScopeRelRelationshipCollection();

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