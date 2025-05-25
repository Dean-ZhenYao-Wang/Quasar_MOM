using MOM.Application.DTOs.Resource.Responses;
using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.DTOs.Personnel.Requests
{
    public class PersonRequest
    {
        /// <summary>
        /// UserName 账号
        /// </summary>
        public required string Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// 在职\休假\离职
        /// </summary>
        public required PersonWorkStatus WorkStatus { get; set; } = PersonWorkStatus.Employed;

        /// <summary>
        /// 备注
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 班组
        /// </summary>
        public Guid? TeamDtId { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        public required Guid OrgDtId { get; set; }

        /// <summary>
        /// 职位/角色
        /// </summary>
        public required IEnumerable<Guid>? PositionDtId_List { get; set; }

        public virtual Person ToPerson()
        {
            Person person = new Person(Id, Name, WorkStatus, Email, PhoneNumber, TeamDtId, OrgDtId, PositionDtId_List, Description);
            return person;
        }
    }
}