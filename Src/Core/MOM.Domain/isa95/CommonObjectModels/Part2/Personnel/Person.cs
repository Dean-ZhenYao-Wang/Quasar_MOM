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
        /// 所属设备角色层次/所属组织
        /// </summary>
        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }

        /// <summary>
        /// 当前操作位置
        /// </summary>
        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        /// <summary>
        /// 当前操作位置类型
        /// </summary>
        [JsonPropertyName("operationalLocationType")]
        public PersonOperationalLocationType? OperationalLocationType { get; set; }

        [JsonIgnore]
        public virtual List<PersonDefinedByRelationship> DefinedBy { get; set; } = new List<PersonDefinedByRelationship>();

        /// <summary>
        /// 定制属性
        /// </summary>
        public PersonProperty Property { get; set; } = new PersonProperty();

        /// <summary>
        /// 确定交换的信息在基于角色的设备层次结构中的位置。可选地，层次结构作用域定义人员定义的作用域。
        /// </summary>
        //[MaxLength(1)]
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }
        /// <summary>
        /// 确定交换的信息在基于角色的设备层次结构中的位置。可选地，层次结构作用域定义人员定义的作用域。
        /// </summary>
        public Guid? HierarchyScopeRelDtId { get; set; }

        //[MaxLength(1)]
        [JsonIgnore]
        public virtual List<PersonOperationalLocationRelRelationship> OperationalLocationRel { get; set; } = new List<PersonOperationalLocationRelRelationship>();
        /// <summary>
        /// 在空间上将人物角色定义为零维点、一维线、二维形状或三维实体<br/>
        /// / / WKT / POLYGON（(-646.99 676.18, -645.14 683.09, -)）
        /// </summary>
        [JsonIgnore]
        public SpatialDefinition SpatialDefinition { get; set; }


        public string? Description { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public GenderType Gender { get; set; } = 0;

        /// <summary>
        /// 联系方式
        /// </summary>
        public ContactInformation ContactInformation { get; set; } = new ContactInformation();

        /// <summary>
        /// 照片
        /// </summary>
        public string Photo { get; set; } = string.Empty;

        /// <summary>
        /// 工作状态：在职\休假\离职
        /// </summary>
        public PersonWorkStatus WorkStatus { get; set; }

        /// <summary>
        /// 是否已锁定账号
        /// </summary>
        public bool LockoutOnFailure { get; set; }

        /// <summary>
        /// 账号锁定时间
        /// </summary>
        public DateTime? LockoutDateTime { get; set; }

        public string PassWord { get; set; } = string.Empty;

        /// <summary>
        /// 密码错误次数
        /// </summary>
        public int FailedCount { get; set; } = 0;

        /// <summary>
        /// 其变更会立即使所有已颁发的Toekn失效
        /// </summary>
        public string SecurityStamp { get; set; } = Guid.NewGuid().ToString(); // 示例初始化

        /// <summary>
        /// 扩展权限,对人员类权限的扩展或限制,此条件仅针对个人有效
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
                this.DefinedByAddTarget(positionDtId_List, "职位");
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
                this.DefinedByAddTarget(positionDtId_List, "职位");
            }

        }
        /// <summary>
        /// 仅绑定ID，并未绑定对象
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
        /// 班组绑定
        /// </summary>
        /// <param name="teamDtId"></param>
        public void TeamAddTarget(Guid? teamDtId)
        {
            bool add = true;
            foreach (var item in this.DefinedBy.Where(m => m.Target.Description.Equals("班组")))
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
        /// 所属人员类绑定
        /// </summary>
        /// <param name="targetDtId"></param>
        private void DefinedByAddTarget(Guid targetDtId)
        {
            this.DefinedBy.Add(new Common.Relationship.isa95.Person.PersonDefinedByRelationship(this.DtId, targetDtId));
        }
        /// <summary>
        /// 所属人员类绑定
        /// </summary>
        /// <param name="targetDtIds">要绑定的人员类唯一标识清单</param>
        /// <param name="type">要绑定的人员类分类</param>
        public void DefinedByAddTarget(IEnumerable<Guid> targetDtIds, string type)
        {
            List<Guid> A = this.DefinedBy.Where(m => m.Target != null && m.Target.Description.Equals(type)).Select(m => m.TargetId).ToList();
            // A中有但B中没有的元素,需要删除的角色
            List<Guid> aNotInB = A.Except(targetDtIds).ToList();
            foreach (var item in DefinedBy.Where(m => aNotInB.Contains(m.TargetId)))
            {
                item.IsDelete = true;
            }

            // B中有但A中没有的元素，需要添加的角色
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