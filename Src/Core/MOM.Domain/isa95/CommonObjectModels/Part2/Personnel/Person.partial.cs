using MOM.Domain.Common;
using MOM.Domain.Common.EnumType;
using MOM.Domain.Permission;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    public partial class Person
    {
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

            var haveDtIds = this.HasValuesOf.Select(m => m.TargetId).ToList();
            人员特征列表在修改时的增删改处理(properties, haveDtIds);
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
                    old.IsDelete = true;
                this.HierarchyScopeRelAddTarget(newOrgDtID);
            }
        }
        private void HierarchyScopeRelAddTarget(Guid orgDtId)
        {
            this.HierarchyScopeRelDtId = orgDtId;
        }

        private void 人员特征列表在修改时的增删改处理(IEnumerable<PersonProperty> properties, List<Guid> haveDtIds)
        {
            if (properties == null) properties = new List<PersonProperty>();
            var requestDtIds = properties.Select(m => m.DtId).ToList();
            var notHaveDtIds = requestDtIds.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(requestDtIds);
            //已有的修改
            foreach (var m in properties.Where(m => haveDtIds.Contains(m.DtId)))
            {
                var property = this.HasValuesOf.Where(m => m.TargetId.Equals(m.DtId)).FirstOrDefault().Target;
                property.Update(m.Id, m.Description, m.Value, m.ValueUnitOfMeasure);
                PropertyContiansUpdate(m, property);
            }
            //没有的添加
            foreach (var m in properties.Where(m => notHaveDtIds.Contains(m.DtId)))
            {
                this.HasValuesOfAddTarget(m);
            }
            //删除的删除
            foreach (var item in this.HasValuesOf.Where(m => deleteDtIds.Contains(m.TargetId)))
            {
                item.IsDelete = true;
            }
        }

        private void PropertyContiansUpdate(PersonProperty propertyViewModel, PersonProperty property)
        {
            var havePropertyDtIds = property.Contains.Select(m => m.TargetId).ToList();
            var requestPropertyDtIds = propertyViewModel.Contains.Select(m => m.TargetId).ToList();
            var notPropertyHaveDtIds = requestPropertyDtIds.Except(havePropertyDtIds);
            var deletePropertyDtIds = havePropertyDtIds.Except(requestPropertyDtIds);
            //已有的修改
            foreach (var pm in propertyViewModel.Contains.Where(c => havePropertyDtIds.Contains(c.TargetId)))
            {
                var childProperty = property.Contains.Where(pc => pc.TargetId.Equals(pm.TargetId)).FirstOrDefault().Target;
                childProperty.Update(pm.Target.Id, pm.Target.Description, pm.Target.Value, pm.Target.ValueUnitOfMeasure);
                PropertyContiansUpdate(pm.Target, childProperty);
            }
            //没有的添加
            foreach (var p in propertyViewModel.Contains.Where(c => notPropertyHaveDtIds.Contains(c.TargetId)))
            {
                property.ContainsAddTarget(p.Target);
            }
            //删除的删除
            property.Contains.Remove(deletePropertyDtIds);
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
            this.DefinedBy.Remove(aNotInB);

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

        public void HasValuesOfAddTarget(PersonProperty personProperty)
        {
            this.HasValuesOf.Add(new Common.Relationship.isa95.Person.PersonHasValuesOfRelationship(this, personProperty));
        }
    }
}