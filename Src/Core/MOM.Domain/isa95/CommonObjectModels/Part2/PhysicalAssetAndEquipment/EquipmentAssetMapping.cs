namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;
    /// <summary>
    /// �豸�ʲ�ӳ��
    /// </summary>
    /// <remarks>
    /// <para>�����ʲ����豸֮��Ĺ�ϵӦ��ʾΪ�豸�ʲ�ӳ��</para>
    /// <para>��ӳ���¼�豸�����������ʲ����������ʱ���</para>
    /// </remarks>
    public class EquipmentAssetMapping : BaseEntity, IEquatable<EquipmentAssetMapping>
    {
        /// <summary>
        /// ִ�����칦�ܵ��豸
        /// </summary>
        /// <remarks>
        /// ��¼ʹ�õ�
        /// </remarks>
        [JsonIgnore]
        public virtual EquipmentAssetMappingRecordsUseOfEquipmentRelationship RecordsUseOfEquipment { get; set; }
        /// <summary>
        /// ���豸�����������ʲ����������ʲ������칦�����ʱ��
        /// </summary>
        /// <remarks>
        /// ��¼ʹ�õ�
        /// </remarks>
        [JsonIgnore]
        public virtual EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship RecordsUseOfPhysicalAsset { get; set; }
        /// <summary>
        /// ӳ��Ԫ�صĲ�����Ϣ
        /// </summary>
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
        /// ��ʼʱ��
        /// </summary>
        /// <remarks>
        /// ������ϵ�Ŀ�ʼʱ��
        /// </remarks>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        /// <remarks>
        /// ������ϵ�Ľ���ʱ��
        /// </remarks>
        public DateTime? EndTime { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentAssetMapping);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentAssetMapping? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && StartTime == other.StartTime && EndTime == other.EndTime;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentAssetMapping? left, EquipmentAssetMapping? right)
        {
            return EqualityComparer<EquipmentAssetMapping?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentAssetMapping? left, EquipmentAssetMapping? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode());
        }
    }
}