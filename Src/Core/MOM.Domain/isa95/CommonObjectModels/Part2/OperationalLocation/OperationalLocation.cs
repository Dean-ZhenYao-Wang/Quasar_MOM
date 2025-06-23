namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationalLocation;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    /// <summary>
    /// ����λ��
    /// </summary>
    /// <remarks>
    /// <para>�������Ρ����������Ρ��豸�������ʲ�����Ա������Ԥ���������߼�������λ��Ӧ��ʾΪ����λ�á�</para>
    /// <para>����λ�ÿ�����������λ�����</para>
    /// </remarks>
    public class OperationalLocation : Resource, IEquatable<OperationalLocation>
    {
        /// <summary>
        /// �˲���λ�������Ĳ���λ�����
        /// </summary>
        /// <remarks>
        /// ��ϵ���ͣ�����
        /// </remarks>
        [JsonIgnore]
        public virtual List<OperationalLocationDefinedByRelationship> DefinedBy { get; set; } = new List<OperationalLocationDefinedByRelationship>();

        /// <summary>
        /// �˲���λ�õ�����ֵ
        /// </summary>
        [JsonIgnore]
        public virtual OperationalLocationProperty HasValuesOf { get; set; }

        /// <summary>
        /// ��...���
        /// </summary>
        /// <remarks>
        /// �����ڴ˲���λ���е��Ӳ���λ��
        /// </remarks>
        [JsonIgnore]
        public virtual List<OperationalLocationIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<OperationalLocationIsMadeUpOfRelationship>();

        /// <summary>
        /// ����
        /// </summary>
        /// <remarks>
        /// ��������λ�õĲ�����Ϣ������
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
        /// �ڿռ��Ͻ��豸����Ϊ��ά�㡢һά�ߡ���ά��״����άʵ�塣
        /// </summary>
        [JsonIgnore]
        public SpatialDefinition SpatialDefinition { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocation);
        }

        /// <inheritdoc/>
        public bool Equals(OperationalLocation? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperationalLocation? left, OperationalLocation? right)
        {
            return EqualityComparer<OperationalLocation?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperationalLocation? left, OperationalLocation? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}