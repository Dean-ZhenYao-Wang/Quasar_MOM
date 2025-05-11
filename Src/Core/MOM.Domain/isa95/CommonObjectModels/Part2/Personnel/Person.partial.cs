using Microsoft.AspNetCore.Identity;
using MOM.Domain.Common;
using MOM.Domain.Common.EnumType;
using MOM.Domain.Permission;
using System;
using System.Text.Json.Serialization;

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
        /// 在职\休假\离职
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
        public List<AvailablePermission> AvailablePermissions { get; set; } = new();

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
                this.DefinedByAddTarget(OrgDtId.Value);
            }
            if (positionDtId_List != null)
            {
                foreach (var positionDtId in positionDtId_List)
                {
                    this.DefinedByAddTarget(positionDtId);
                }
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
            foreach (var item in DefinedBy)
            {
                DefinedBy.Remove(item);
            }
            if (teamOfGroupDtId != null)
            {
                this.DefinedByAddTarget(teamOfGroupDtId.Value);
            }
            if (OrgDtId != null)
            {
                this.DefinedByAddTarget(OrgDtId.Value);
            }
            if (positionDtId_List != null)
            {
                foreach (var positionDtId in positionDtId_List)
                {
                    this.DefinedByAddTarget(positionDtId);
                }
            }

            var haveDtIds = this.HasValuesOf.Select(m => m.TargetId).ToList();
            人员特征列表在修改时的增删改处理(properties, haveDtIds);
        }

        private void 人员特征列表在修改时的增删改处理(IEnumerable<PersonProperty> properties,  List<Guid> haveDtIds)
        {
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
            this.HasValuesOf.Remove(deleteDtIds);
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
        /// 所属人员类绑定
        /// </summary>
        /// <param name="teamOfGroupDtId"></param>
        public void DefinedByAddTarget(Guid teamOfGroupDtId)
        {
            this.DefinedBy.Add(new Common.Relationship.isa95.Person.PersonDefinedByRelationship(this.DtId, teamOfGroupDtId));
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