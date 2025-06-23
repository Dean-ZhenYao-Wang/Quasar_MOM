namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    /// <summary>
    /// �����ʲ���
    /// </summary>
    /// <remarks>
    /// <para>�����ʲ����ʾ�������������������ʲ����飬����ά�޺��滻Ŀ�ġ�</para>
    /// <para>�κ������ʲ�������һ�������ʲ��ࡣ</para>
    /// <para>�����ʲ���ɶ���Ϊ������������ʲ�����ػ���Ҳ����������������ʲ�����ɡ�</para>
    /// </remarks>
    public partial class PhysicalAssetClass : ResourceClass, IEquatable<PhysicalAssetClass>
    {
        private PhysicalAssetClass() { }
        /// <summary>
        /// �����ʲ������̵�Ψһ��ʶ��
        /// </summary>
        public string? Manufacturer { get; set; }

        /// <summary>
        /// ��ʾ��ǰ�����ʲ���������������ʲ�������ԣ����Լ̳У�(������ϵ)
        /// </summary>
        [JsonIgnore]
        public virtual List<PhysicalAssetClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<PhysicalAssetClassIncludesPropertiesOfRelationship>();

        /// <summary>
        /// ��ʾ�������ʲ������������ʲ�����Ϊ��ɲ��֣���Ϲ�ϵ��
        /// </summary>
        [JsonIgnore]
        public virtual List<PhysicalAssetClassIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PhysicalAssetClassIsMadeUpOfRelationship>();

        /// <summary>
        /// ��չ����
        /// </summary>
        public virtual PhysicalAssetClassProperty Property { get; set; } = new PhysicalAssetClassProperty();

        /// <summary>
        /// �����ʲ���ĸ���������Ϣ
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// ��ʶ�ڻ��ڽ�ɫ���豸��νṹ�е�λ��
        /// </summary>
        public Guid? HierarchyScopeRelDtId { get; set; }

        /// <summary>
        /// ��ʶ�ڻ��ڽ�ɫ���豸��νṹ�е�λ��
        /// </summary>
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }

        /// <summary>
        /// ���������ʲ������豸��νṹ�еľ��巶Χ����
        /// </summary>
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }

        public PhysicalAssetClass(string ID, string description = "", string manufacturer = "", Guid? hierarchyScopeDtId = null)
        {
            this.Id = Id;
            this.Description = description;
            this.Manufacturer = manufacturer;
            this.HierarchyScopeRelDtId = hierarchyScopeDtId;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetClass);
        }

        /// <inheritdoc/>
        public bool Equals(PhysicalAssetClass? other)
        {
            return other is not null && base.Equals(other) && Manufacturer == other.Manufacturer && HierarchyScope == other.HierarchyScope;
        }

        /// <inheritdoc/>
        public static bool operator ==(PhysicalAssetClass? left, PhysicalAssetClass? right)
        {
            return EqualityComparer<PhysicalAssetClass?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PhysicalAssetClass? left, PhysicalAssetClass? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Manufacturer?.GetHashCode(), HierarchyScope?.GetHashCode());
        }

        /// <inheritdoc/>
        public override void Delete()
        {
            this.IsDelete = true;
        }
    }
}