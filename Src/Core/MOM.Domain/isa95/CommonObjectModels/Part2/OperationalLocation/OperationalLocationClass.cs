namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationalLocationClass;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;
    /// <summary>
    /// ����λ�����
    /// </summary>
    /// <remarks>
    /// <para>��ʾ�����������ԵĲ���λ�÷��飬�����ض�Ŀ�ģ���������Ӫ���塢���ȡ����������ܣ���Ӧ��ʾΪ����λ�����</para>
    /// <para>�κβ���λ�ÿ����������������λ�����ĳ�Ա</para>
    /// </remarks>
    public class OperationalLocationClass : BaseEntity, IEquatable<OperationalLocationClass>
    {
        /// <summary>
        /// ����...������
        /// </summary>
        /// <remarks>
        /// �˲���λ��������Ŀ�����λ����������
        /// </remarks>
        [JsonIgnore]
        public virtual List<OperationalLocationClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<OperationalLocationClassIncludesPropertiesOfRelationship>();
        /// <summary>
        /// ��...���
        /// </summary>
        /// <remarks>
        /// �˸�����λ�������Ϊ���壬���Ӳ���λ�������Ϊ��ɲ���
        /// </remarks>
        [JsonIgnore]
        public virtual List<OperationalLocationClassIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<OperationalLocationClassIsMadeUpOfRelationship>();
        /// <summary>
        /// �˲���λ�������е�����
        /// </summary>
        public OperationalLocationClassProperty Property { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        /// <remarks>
        /// ����λ�����Ĳ�����Ϣ
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

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationClass);
        }

        /// <inheritdoc/>
        public bool Equals(OperationalLocationClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperationalLocationClass? left, OperationalLocationClass? right)
        {
            return EqualityComparer<OperationalLocationClass?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperationalLocationClass? left, OperationalLocationClass? right)
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