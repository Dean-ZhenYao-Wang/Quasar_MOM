namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.Person;
    using MOM.Domain.isa95.CommonObjectModels;
    using MOM.Domain.Permission;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    /// <summary>
    /// ��Ա
    /// </summary>
    /// <remarks>
    /// <para>�ض�ʶ�����ı�ʾӦ��Ϊ��Ա���֡�</para>
    /// <para>��Ա���������������Ա���ĳ�Ա��</para>
    /// </remarks>
    public partial class Person : Resource, IEquatable<Person>
    {
        private Person()
        { }

        private string? operationalLocation;

        /// <summary>
        /// ����Ա֧�ֵ���Ա��𡣸���Ա֧������Ա������������
        /// </summary>
        [JsonIgnore]
        public virtual List<PersonDefinedByRelationship> DefinedBy { get; set; } = new List<PersonDefinedByRelationship>();

        /// <summary>
        /// ����Ա������ֵ
        /// </summary>
        public PersonProperty Property { get; set; } = new PersonProperty();

        /// <summary>
        /// ��������Դ�Ĳ�����Ϣ
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
        public virtual HierarchyScope? HierarchyScopeRel { get; set; }

        /// <summary>
        /// �ռ䶨��
        /// </summary>
        /// <remarks>
        /// ����Ա�ڿռ��϶���Ϊ��ά�㡢һά�ߡ���ά�����ά��
        /// <para>/ / WKT / POLYGON��(-646.99 676.18, -645.14 683.09, -)��</para>
        /// </remarks>
        [JsonIgnore]
        public SpatialDefinition? SpatialDefinition { get; set; }

        /// <summary>
        /// �������λ��
        /// </summary>
        /// <remarks>
        /// <para>�����λ�õĿ�ѡ��ϵ</para>
        /// <para>�Ǳ�׼�淶Ҫ��</para>
        /// </remarks>
        [JsonIgnore]
        [NotMapped]
        public PersonOperationalLocationRelRelationship? OperationalLocationRel { get; set; }

        /// <summary>
        /// ����λ��
        /// </summary>
        /// <remarks>
        /// ��ʶ��Ա�Ĳ���λ��
        /// </remarks>
        public string? OperationalLocation
        {
            get => operationalLocation; set
            {
                if (this.OperationalLocationType.HasValue
                    && this.OperationalLocationType.Value == PersonOperationalLocationType.operationalLocation
                    && string.IsNullOrWhiteSpace(value))
                    throw new Exception("��Ա����λ�ò���ȷ");
                operationalLocation = value;
            }
        }

        /// <summary>
        /// ����λ������
        /// </summary>
        /// <remarks>
        /// ��ʶ����λ���������õ��ǲ���λ�ö����ǰ���λ����������ָ������λ������ʱ����
        /// </remarks>
        public PersonOperationalLocationType? OperationalLocationType { get; set; }

        /// <summary>
        /// ��¼�˺�
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// �Ա�
        /// </summary>
        public GenderType Gender { get; set; } = 0;

        /// <summary>
        /// ��ϵ��ʽ
        /// </summary>
        public ContactInformation ContactInformation { get; set; } = new ContactInformation();

        /// <summary>
        /// ��Ƭ
        /// </summary>
        public string Photo { get; set; } = string.Empty;

        /// <summary>
        /// ����״̬����ְ\�ݼ�\��ְ
        /// </summary>
        public PersonWorkStatus WorkStatus { get; set; }

        /// <summary>
        /// �Ƿ��������˺�
        /// </summary>
        public bool LockoutOnFailure { get; set; }

        /// <summary>
        /// �˺�����ʱ��
        /// </summary>
        public DateTime? LockoutDateTime { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string PassWord { get; set; } = string.Empty;

        /// <summary>
        /// ����������
        /// </summary>
        public int FailedCount { get; set; } = 0;

        /// <summary>
        /// ����������ʹ�����Ѱ䷢�� Toekn ʧЧ
        /// </summary>
        public string SecurityStamp { get; set; } = Guid.NewGuid().ToString(); // ʾ����ʼ��

        /// <summary>
        /// ��չȨ��,����Ա��Ȩ�޵���չ������,����������Ը�����Ч
        /// </summary>
        public virtual List<AvailablePermission> AvailablePermissions { get; set; } = new();

        /// <summary>
        ///
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="name"></param>
        /// <param name="workStatus"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="teamOfGroupDtId"></param>
        /// <param name="OrgDtId"></param>
        /// <param name="positionDtId_List"></param>
        /// <param name="description"></param>
        public Person(string userName, string name, PersonWorkStatus workStatus, string? email = null, string? phoneNumber = null, Guid? teamOfGroupDtId = null, Guid? OrgDtId = null, IEnumerable<Guid>? positionDtId_List = null, string? description = null)
        {
            this.UserName = userName;
            this.WorkStatus = workStatus;
            this.Description = description;
            this.Name = name;
            this.ContactInformation.Email = email;
            this.ContactInformation.PhoneNumber = phoneNumber;
            if (teamOfGroupDtId != null)
            {
                this.DefinedByAddTarget(teamOfGroupDtId.Value);
            }
            if (OrgDtId != null)
            {
                this.HierarchyScopeRelAddTarget(OrgDtId.Value);
            }
            if (positionDtId_List != null)
            {
                this.DefinedByAddTarget(positionDtId_List, "ְλ");
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="workStatus"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="teamOfGroupDtId"></param>
        /// <param name="OrgDtId"></param>
        /// <param name="positionDtId_List"></param>
        /// <param name="description"></param>
        /// <param name="properties"></param>
        public void Update(string ID, string name, PersonWorkStatus workStatus, string? email = null, string? phoneNumber = null, Guid? teamOfGroupDtId = null, Guid? OrgDtId = null, IEnumerable<Guid>? positionDtId_List = null, string? description = null, IEnumerable<PersonProperty>? properties = null)
        {
            this.Id = Id;
            this.WorkStatus = workStatus;
            this.Description = description;
            this.Name = name;
            this.ContactInformation.Email = email;
            this.ContactInformation.PhoneNumber = phoneNumber;
            this.TeamAddTarget(teamOfGroupDtId);
            if (OrgDtId != null)
            {
                this.HierarchyScopeRelAddOrUpdateTarget(this.HierarchyScopeRel, OrgDtId.Value);
            }
            if (positionDtId_List != null)
            {
                this.DefinedByAddTarget(positionDtId_List, "ְλ");
            }
        }

        /// <summary>
        /// ����ID����δ�󶨶���
        /// </summary>
        /// <param name="old"></param>
        /// <param name="newOrgDtID"></param>
        public void HierarchyScopeRelAddOrUpdateTarget(HierarchyScope? old, Guid newOrgDtID)
        {
            if (old == null)
                this.HierarchyScopeRelAddTarget(newOrgDtID);
            else
            {
                if (old != null)
                    this.HierarchyScopeRelDtId = null;
                this.HierarchyScopeRelAddTarget(newOrgDtID);
            }
        }

        private void HierarchyScopeRelAddTarget(Guid orgDtId)
        {
            this.HierarchyScopeRelDtId = orgDtId;
        }

        /// <summary>
        /// �����
        /// </summary>
        /// <param name="teamDtId"></param>
        public void TeamAddTarget(Guid? teamDtId)
        {
            bool add = true;
            foreach (var item in this.DefinedBy.Where(m => m.Target.Description.Equals("����")))
            {
                if (item.TargetId != teamDtId)
                {
                    item.IsDelete = true;
                }
                else
                {
                    add = false;
                }
            }
            if (add && teamDtId != null)
                this.DefinedByAddTarget(teamDtId.Value);
        }

        /// <summary>
        /// ������Ա���
        /// </summary>
        /// <param name="targetDtId"></param>
        private void DefinedByAddTarget(Guid targetDtId)
        {
            this.DefinedBy.Add(new Common.Relationship.isa95.Person.PersonDefinedByRelationship(this.DtId, targetDtId));
        }

        /// <summary>
        /// ������Ա���
        /// </summary>
        /// <param name="targetDtIds">Ҫ�󶨵���Ա��Ψһ��ʶ�嵥</param>
        /// <param name="type">Ҫ�󶨵���Ա�����</param>
        public void DefinedByAddTarget(IEnumerable<Guid> targetDtIds, string type)
        {
            List<Guid> A = this.DefinedBy.Where(m => m.Target != null && m.Target.Description.Equals(type)).Select(m => m.TargetId).ToList();
            // A���е�B��û�е�Ԫ��,��Ҫɾ���Ľ�ɫ
            List<Guid> aNotInB = A.Except(targetDtIds).ToList();
            foreach (var item in DefinedBy.Where(m => aNotInB.Contains(m.TargetId)))
            {
                item.IsDelete = true;
            }

            // B���е�A��û�е�Ԫ�أ���Ҫ��ӵĽ�ɫ
            List<Guid> bNotInA = targetDtIds.Except(A).ToList();

            foreach (var positionDtId in bNotInA)
            {
                this.DefinedByAddTarget(positionDtId);
            }
        }

        /// <inheritdoc/>
        public override void Delete()
        {
            base.Delete();
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        /// <inheritdoc/>
        public bool Equals(Person? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && Name == other.Name && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType;
        }

        /// <inheritdoc/>
        public static bool operator ==(Person? left, Person? right)
        {
            return EqualityComparer<Person?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), Name?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode());
        }

        /// <inheritdoc/>
        public List<string> GetDefinedBy()
        {
            return this.DefinedBy.Select(m => m.Target.Id).ToList();
        }
    }
}