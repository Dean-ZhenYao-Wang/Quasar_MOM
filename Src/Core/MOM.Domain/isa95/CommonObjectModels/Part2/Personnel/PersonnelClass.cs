namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using MOM.Domain.Permission;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;
    /// <summary>
    /// ��Ա���
    /// </summary>
    /// <remarks>
    /// <para>��ʾ�����������Ե���Ա���飬�����ض�Ŀ�ģ���������Ӫ���塢���ȡ����������ܣ���Ӧ��ʾΪ��Ա���</para>
    /// <para>�κ���Ա���������������Ա���ĳ�Ա��</para>
    /// <para>��Ա���ɶ���Ϊ���������Ա�����ػ���</para>
    /// <para>��Ա���������������Ա������</para>
    /// </remarks>
    public partial class PersonnelClass : ResourceClass, IEquatable<PersonnelClass>
    {
        private PersonnelClass() { }
        /// <summary>
        /// ����Ա������Ŀ����Ա��������
        /// </summary>
        [JsonIgnore]
        public virtual List<PersonnelClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<PersonnelClassIncludesPropertiesOfRelationship>();
        /// <summary>
        /// ����Ա�����е���Ա�������
        /// </summary>
        public PersonnelClassProperty Property { get; set; } = new PersonnelClassProperty();
        /// <summary>
        /// ��Ա���Ĳ�����Ϣ������
        /// </summary>
        public string Description { get; set; }
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
        /// ��ע-ҳ������ʾ���û����ģ��û��Լ��༭�ı�ע��Ϣ
        /// </summary>
        public string? Remark { get; set; }

        /// <summary>
        /// ������DtId
        /// </summary>
        public Guid? ResponsibleDtId { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public virtual Person Responsible { get; set; }

        /// <summary>
        /// Ȩ���嵥���ɷ��ʵĲ˵���ť�嵥
        /// </summary>
        public virtual List<Permission.PersonnelClassPermission> Permissions { get; set; } = new List<PersonnelClassPermission>();


        public PersonnelClass(string Id, string name, string? description = null, HierarchyScope? hierarchyScope = null) 
        {
            this.Id = Id;
            this.Name = name;
            this.Description = description;
            if (hierarchyScope != null)
            {
                this.HierarchyScopeRelDtId = hierarchyScope.DtId;
                this.HierarchyScopeRel = hierarchyScope;
            }
        }

        public void Update(string ID, Guid? responsibleDtId)
        {
            this.Id = Id;
            this.ResponsibleDtId = responsibleDtId;
        }

        public override void Delete()
        {
            this.HierarchyScopeRelDtId = null;
            this.HierarchyScopeRel = null;
            this.IncludesPropertiesOf.Clear();
            base.Delete();
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelClass);
        }

        /// <inheritdoc/>
        public bool Equals(PersonnelClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        /// <inheritdoc/>
        public static bool operator ==(PersonnelClass? left, PersonnelClass? right)
        {
            return EqualityComparer<PersonnelClass?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PersonnelClass? left, PersonnelClass? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }

        /// <inheritdoc/>
        public List<Guid> GetHaveChildClassDtIdList()
        {
            return this.IncludesPropertiesOf.Where(m => m.Target.IsDelete == false).Select(m => m.DtId).ToList();
        }

        /// <inheritdoc/>
        public void IncludesPropertiesOfAddTarget(Guid targetDtId)
        {
            this.IncludesPropertiesOf.Add(new PersonnelClassIncludesPropertiesOfRelationship(this.DtId, targetDtId));
        }

        /// <inheritdoc/>
        public void IncludesPropertiesOfRemoveTargets(IEnumerable<Guid> deleteDtIds)
        {
            this.IncludesPropertiesOf.RemoveAll(m => deleteDtIds.Contains(m.TargetId));
        }

        /// <inheritdoc/>
        public void IncludesPropertiesOfAddTarget(PersonnelClass target)
        {
            this.IncludesPropertiesOf.Add(new PersonnelClassIncludesPropertiesOfRelationship(this, target));
        }
    }
}