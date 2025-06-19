namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAsset;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;
    /// <summary>
    /// �����ʲ�
    /// </summary>
    /// <remarks>
    /// �����豸Ӧ��ʾΪ�����ʲ�
    /// </remarks>
    public class PhysicalAsset : Resource, IEquatable<PhysicalAsset>
    {
        /// <summary>
        /// �̶��ʲ�ID
        /// </summary>
        /// <remarks>
        /// �������ɻ򷨹�Ҫ��Ĳ���׷��Ψһ��ʶ
        /// </remarks>
        public required string FixedAssetID { get; set; }
        /// <summary>
        /// ��Ӧ��ID
        /// </summary>
        /// <remarks>
        /// ������Ӧ�����к�
        /// </remarks>
        public string? VendorID { get; set; }
        /// <summary>
        /// �ռ䶨��
        /// </summary>
        /// <remarks>
        /// �������ʲ��ڿռ��϶���Ϊ��ά�㡢һά�ߡ���ά�����ά��
        /// </remarks>
        public SpatialDefinition SpatialDefinition { get; set; }
        /// <summary>
        /// ��...����
        /// </summary>
        /// <remarks>
        /// �������ʲ�֧�ֵ������ʲ���𡣸������ʲ�֧���������ʲ�������������
        /// <para>��ϵ���ͣ�����</para>
        /// </remarks>
        [JsonIgnore]
        public virtual List<PhysicalAssetDefinedByRelationship> DefinedBy { get; set; } = new List<PhysicalAssetDefinedByRelationship>();
        /// <summary>
        /// �������ʲ�������ֵ
        /// </summary>
        public virtual PhysicalAssetProperty Property { get; set; } = new PhysicalAssetProperty();
        /// <summary>
        /// ��...���
        /// </summary>
        /// <remarks>
        /// ��ض�����Ϊ���幹�ɴ������ʲ���һ����
        /// </remarks>
        [JsonIgnore]
        public virtual List<PhysicalAssetIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PhysicalAssetIsMadeUpOfRelationship>();
        /// <summary>
        /// ����
        /// </summary>
        /// <remarks>
        /// �����ʲ��Ĳ�����Ϣ
        /// </remarks>
        public string? Description { get; set; }
        /// <summary>
        /// �㼶��Χ
        /// </summary>
        /// <remarks>
        /// ��ʶ������Ϣ�ڻ��ڽ�ɫ���豸�㼶�е�λ�á���ѡ�أ��㼶��Χ�ɶ��������ʲ����ķ�Χ���綨���վ�������
        /// <para>��㼶�Ŀ�ѡ��ϵ</para>
        /// <para>�Ǳ�׼�淶Ҫ��</para>
        /// </remarks>
        public Guid? HierarchyScopeRelDtId { get; set; }
        /// <summary>
        /// �㼶��Χ
        /// </summary>
        /// <remarks>
        /// ��ʶ������Ϣ�ڻ��ڽ�ɫ���豸�㼶�е�λ�á���ѡ�أ��㼶��Χ�ɶ��������ʲ����ķ�Χ���綨���վ�������
        /// <para>��㼶�Ŀ�ѡ��ϵ</para>
        /// <para>�Ǳ�׼�淶Ҫ��</para>
        /// </remarks>
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }
        /// <summary>
        /// ����㼶��Χ
        /// </summary>
        /// <remarks>
        /// <para>��㼶�Ŀ�ѡ��ϵ</para>
        /// <para>�Ǳ�׼�淶Ҫ��</para>
        /// </remarks>
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }

        /// <summary>
        /// ����λ��
        /// </summary>
        /// <remarks>
        /// ��������λ����Ϣ�����ַ�����꣩
        /// </remarks>
        public string PhysicalLocation { get; set; }
        /// <summary>
        /// ��������λ��
        /// </summary>
        /// <remarks>
        /// <para>������λ�õĿ�ѡ��ϵ</para>
        /// <para>�Ǳ�׼�淶Ҫ��</para>
        /// </remarks>
        [JsonIgnore]
        public virtual Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation PhysicalLocationRel { get; set; }
        /// <summary>
        /// ����λ������
        /// </summary>
        /// <remarks>
        /// ��ʶ����λ���������õ��ǲ���λ�ö����ǰ���λ������
        /// </remarks>
        public PhysicalAssetPhysicalLocationType PhysicalLocationType { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAsset);
        }

        /// <inheritdoc/>
        public bool Equals(PhysicalAsset? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && FixedAssetID == other.FixedAssetID && VendorID == other.VendorID && PhysicalLocation == other.PhysicalLocation && PhysicalLocationType == other.PhysicalLocationType;
        }

        /// <inheritdoc/>
        public static bool operator ==(PhysicalAsset? left, PhysicalAsset? right)
        {
            return EqualityComparer<PhysicalAsset?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PhysicalAsset? left, PhysicalAsset? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), FixedAssetID?.GetHashCode(), VendorID?.GetHashCode(), PhysicalLocation?.GetHashCode(), PhysicalLocationType.GetHashCode());
        }
    }
}