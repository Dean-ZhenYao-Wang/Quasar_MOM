namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.EquipmentClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    /// <summary>
    /// �豸���
    /// </summary>
    /// <remarks>
    /// <para>��ʾ�����������Ե��豸���飬�����ض�Ŀ�ģ���������Ӫ���塢���ȡ����������ܣ���Ӧ��ʾΪ�豸���</para>
    /// <para>�κ��豸��������������豸���ĳ�Ա��</para>
    /// <para>�豸���ɶ���Ϊ��������豸�����ػ���</para>
    /// <para>�豸��������������豸������</para>
    /// </remarks>
    public partial class EquipmentClass : ResourceClass, IEquatable<EquipmentClass>
    {
        private EquipmentClass() { }
        /// <summary>
        /// ��ǰ����������ӷ��ࡣ<br/>
        /// ���ӹ�ϵ����Ҫ����������ࡢһ���ࡢ�����ࡢ�����ࡢ�����ࡢ������ȣ�<br/>
        /// �豸->��Ҫ�豸->�����豸<br/>
        /// �豸->��Ҫ�豸->�����豸<br/>
        /// �豸->����->��װ����
        /// </summary>
        /// <remarks>
        /// ����...������
        /// <para>���豸������Ŀ���豸��������</para>
        /// </remarks>
        [JsonIgnore]
        public virtual List<EquipmentClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<EquipmentClassIncludesPropertiesOfRelationship>();

        /// <summary>
        /// ������豸�������豸������塣<br/>
        /// ��ɹ�ϵ��������豸����練Ӧ����ѹ������CNC���泵���г��ȣ�<br/>
        /// ��װ����->A���豸<br/>
        /// ��װ����->B���豸<br/>
        /// A���豸��B���豸��ͬ��ɹ�װ����
        /// </summary>
        /// <remarks>
        /// ��...���
        /// <para>�˸��豸�����Ϊ���壬�����豸�����Ϊ��ɲ���</para>
        /// </remarks>
        [JsonIgnore]
        public virtual List<EquipmentClassIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentClassIsMadeUpOfRelationship>();

        /// <summary>
        /// ���е�����
        /// </summary>
        public virtual EquipmentClassProperty Property { get; set; } = new EquipmentClassProperty();

        /// <summary>
        /// ����
        /// </summary>
        /// <remarks>
        /// �豸���Ĳ�����Ϣ
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
        public virtual HierarchyScope? HierarchyScopeRel { get; set; }

        /// <summary>
        /// �豸�㼶
        /// </summary>
        public EquipmentClassEquipmentLevel? EquipmentLevel { get; set; }

        /// <summary>
        /// �����ӷ���
        /// </summary>
        /// <param name="childClassDtId"></param>
        public void UpdateIncludesPropertiesOf(List<Guid> childClassDtId)
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

        /// <summary>
        /// ���µ�ǰ�豸�����ɲ���
        /// </summary>
        /// <param name="childClassDtId"></param>
        public async void UpdateIsMadeUpOf(List<Guid> childClassDtId)
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

        /// <summary>
        /// ���µ�ǰ�豸��
        /// </summary>
        /// <param name="iD"></param>
        /// <param name="description"></param>
        /// <param name="equipmentLevel"></param>
        public void Update(string iD, string? description, EquipmentClassEquipmentLevel? equipmentLevel)
        {
            this.Id = Id;
            this.Description = description;
            this.EquipmentLevel = equipmentLevel;
        }

        /// <summary>
        /// ��ɾ����ǰ�豸��
        /// </summary>
        public override void Delete()
        {
            this.IncludesPropertiesOf.Clear();
            base.Delete();
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClass);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && EquipmentLevel == other.EquipmentLevel;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentClass? left, EquipmentClass? right)
        {
            return EqualityComparer<EquipmentClass?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentClass? left, EquipmentClass? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), EquipmentLevel?.GetHashCode());
        }
    }
}