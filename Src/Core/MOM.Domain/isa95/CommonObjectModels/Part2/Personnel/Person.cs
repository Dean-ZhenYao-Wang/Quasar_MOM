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
    /// 人员
    /// </summary>
    /// <remarks>
    /// <para>特定识别个体的表示应作为人员呈现。</para>
    /// <para>人员可以是零个或多个人员类别的成员。</para>
    /// </remarks>
    public partial class Person : Resource, IEquatable<Person>
    {
        private Person()
        { }

        private string? operationalLocation;

        /// <summary>
        /// 此人员支持的人员类别。该人员支持与人员类别关联的属性
        /// </summary>
        [JsonIgnore]
        public virtual List<PersonDefinedByRelationship> DefinedBy { get; set; } = new List<PersonDefinedByRelationship>();

        /// <summary>
        /// 此人员的属性值
        /// </summary>
        public PersonProperty Property { get; set; } = new PersonProperty();

        /// <summary>
        /// 描述。资源的补充信息
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 层级范围
        /// </summary>
        /// <remarks>
        /// 标识交换信息在基于角色的设备层级中的位置。可选地，层级范围可定义物理资产类别的范围（如定义的站点或区域）
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        public Guid? HierarchyScopeRelDtId { get; set; }

        /// <summary>
        /// 层级范围
        /// </summary>
        /// <remarks>
        /// 标识交换信息在基于角色的设备层级中的位置。可选地，层级范围可定义物理资产类别的范围（如定义的站点或区域）
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }

        /// <summary>
        /// 适配层级范围
        /// </summary>
        /// <remarks>
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope? HierarchyScopeRel { get; set; }

        /// <summary>
        /// 空间定义
        /// </summary>
        /// <remarks>
        /// 将人员在空间上定义为零维点、一维线、二维面或三维体
        /// <para>/ / WKT / POLYGON（(-646.99 676.18, -645.14 683.09, -)）</para>
        /// </remarks>
        [JsonIgnore]
        public SpatialDefinition? SpatialDefinition { get; set; }

        /// <summary>
        /// 适配操作位置
        /// </summary>
        /// <remarks>
        /// <para>与操作位置的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        [JsonIgnore]
        [NotMapped]
        public PersonOperationalLocationRelRelationship? OperationalLocationRel { get; set; }

        /// <summary>
        /// 操作位置
        /// </summary>
        /// <remarks>
        /// 标识人员的操作位置
        /// </remarks>
        public string? OperationalLocation
        {
            get => operationalLocation; set
            {
                if (this.OperationalLocationType.HasValue
                    && this.OperationalLocationType.Value == PersonOperationalLocationType.operationalLocation
                    && string.IsNullOrWhiteSpace(value))
                    throw new Exception("人员操作位置不明确");
                operationalLocation = value;
            }
        }

        /// <summary>
        /// 操作位置类型
        /// </summary>
        /// <remarks>
        /// 标识操作位置属性引用的是操作位置对象还是包含位置描述。当指定操作位置属性时必填
        /// </remarks>
        public PersonOperationalLocationType? OperationalLocationType { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        public string UserName { get; set; }

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

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; } = string.Empty;

        /// <summary>
        /// 密码错误次数
        /// </summary>
        public int FailedCount { get; set; } = 0;

        /// <summary>
        /// 其变更会立即使所有已颁发的 Toekn 失效
        /// </summary>
        public string SecurityStamp { get; set; } = Guid.NewGuid().ToString(); // 示例初始化

        /// <summary>
        /// 扩展权限,对人员类权限的扩展或限制,此条件仅针对个人有效
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
                this.DefinedByAddTarget(positionDtId_List, "职位");
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
                this.DefinedByAddTarget(positionDtId_List, "职位");
            }
        }

        /// <summary>
        /// 仅绑定ID，并未绑定对象
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