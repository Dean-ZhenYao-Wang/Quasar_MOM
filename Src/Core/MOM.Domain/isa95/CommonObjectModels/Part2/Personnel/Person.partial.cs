using Microsoft.AspNetCore.Identity;
using MOM.Domain.Common.EnumType;
using MOM.Domain.Permission;
using System.Text.Json.Serialization;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    public partial class Person
    {
        public string? Description { get; set; }
        /// <summary>
        /// 在职\休假\离职
        /// </summary>
        public PersonWorkStatus WorkStatus { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
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

        public Person(string Id, string name, PersonWorkStatus workStatus, string? email = null, string? phoneNumber = null, Guid? teamOfGroupDtId = null, Guid? departmentDtId = null, IEnumerable<Guid>? positionDtId_List = null, string? description = null) : this()
        {
            this.Id = Id;
            this.WorkStatus = workStatus;
            this.Description = description;
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            if (teamOfGroupDtId != null)
            {
                this.DefinedByAddTarget(teamOfGroupDtId.Value);
            }
            if (departmentDtId != null)
            {
                this.DefinedByAddTarget(departmentDtId.Value);
            }
            if (positionDtId_List != null)
            {
                foreach (var positionDtId in positionDtId_List)
                {
                    this.DefinedByAddTarget(positionDtId);
                }
            }
        }

        public void Update(string ID, string name, PersonWorkStatus workStatus, string? email = null, string? phoneNumber = null, Guid? teamOfGroupDtId = null, Guid? departmentDtId = null, IEnumerable<Guid>? positionDtId_List = null, string? description = null)
        {
            this.Id = Id;
            this.WorkStatus = workStatus;
            this.Description = description;
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            foreach (var item in DefinedBy)
            {
                DefinedBy.Remove(item);
            }
            if (teamOfGroupDtId != null)
            {
                this.DefinedByAddTarget(teamOfGroupDtId.Value);
            }
            if (departmentDtId != null)
            {
                this.DefinedByAddTarget(departmentDtId.Value);
            }
            if (positionDtId_List != null)
            {
                foreach (var positionDtId in positionDtId_List)
                {
                    this.DefinedByAddTarget(positionDtId);
                }
            }

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