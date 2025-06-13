namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.Person;
    using MOM.Domain.isa95.CommonObjectModels;
    using MOM.Domain.Permission;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    public partial class Person : Resource, IEquatable<Person>
    {
        public Person()
        {
        }

        /// <summary>
        /// �����豸��ɫ���/������֯
        /// </summary>
        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }

        /// <summary>
        /// ��ǰ����λ��
        /// </summary>
        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        /// <summary>
        /// ��ǰ����λ������
        /// </summary>
        [JsonPropertyName("operationalLocationType")]
        public PersonOperationalLocationType? OperationalLocationType { get; set; }

        [JsonIgnore]
        public virtual List<PersonDefinedByRelationship> DefinedBy { get; set; } = new List<PersonDefinedByRelationship>();

        /// <summary>
        /// ��������
        /// </summary>
        public PersonProperty Property { get; set; } = new PersonProperty();

        /// <summary>
        /// ȷ����������Ϣ�ڻ��ڽ�ɫ���豸��νṹ�е�λ�á���ѡ�أ���νṹ����������Ա�����������
        /// </summary>
        //[MaxLength(1)]
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }
        /// <summary>
        /// ȷ����������Ϣ�ڻ��ڽ�ɫ���豸��νṹ�е�λ�á���ѡ�أ���νṹ����������Ա�����������
        /// </summary>
        public Guid? HierarchyScopeRelDtId { get; set; }

        //[MaxLength(1)]
        [JsonIgnore]
        public virtual List<PersonOperationalLocationRelRelationship> OperationalLocationRel { get; set; } = new List<PersonOperationalLocationRelRelationship>();
        /// <summary>
        /// �ڿռ��Ͻ������ɫ����Ϊ��ά�㡢һά�ߡ���ά��״����άʵ��<br/>
        /// / / WKT / POLYGON��(-646.99 676.18, -645.14 683.09, -)��
        /// </summary>
        [JsonIgnore]
        public SpatialDefinition SpatialDefinition { get; set; }


        public string? Description { get; set; }

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

        public string PassWord { get; set; } = string.Empty;

        /// <summary>
        /// ����������
        /// </summary>
        public int FailedCount { get; set; } = 0;

        /// <summary>
        /// ����������ʹ�����Ѱ䷢��ToeknʧЧ
        /// </summary>
        public string SecurityStamp { get; set; } = Guid.NewGuid().ToString(); // ʾ����ʼ��

        /// <summary>
        /// ��չȨ��,����Ա��Ȩ�޵���չ������,����������Ը�����Ч
        /// </summary>
        public virtual List<AvailablePermission> AvailablePermissions { get; set; } = new();

        public Person(string Id, string name, PersonWorkStatus workStatus, string? email = null, string? phoneNumber = null, Guid? teamOfGroupDtId = null, Guid? OrgDtId = null, IEnumerable<Guid>? positionDtId_List = null, string? description = null) : this()
        {
            this.Id = Id;
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

        public void Update(string ID, string name, PersonWorkStatus workStatus, string? email = null, string? phoneNumber = null, Guid? teamOfGroupDtId = null, Guid? OrgDtId = null, IEnumerable<Guid>? positionDtId_List = null, string? description = null, IEnumerable<PersonProperty> properties = null)
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
        public void HierarchyScopeRelAddOrUpdateTarget(HierarchyScope old, Guid newOrgDtID)
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

        public void Delete()
        {
            this.IsDelete = true;
        }


        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && Name == other.Name && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType;
        }

        public static bool operator ==(Person? left, Person? right)
        {
            return EqualityComparer<Person?>.Default.Equals(left, right);
        }

        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), Name?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode());
        }

        public List<string> GetDefinedBy()
        {
            return this.DefinedBy.Select(m => m.Target.Id).ToList();
        }
    }
}