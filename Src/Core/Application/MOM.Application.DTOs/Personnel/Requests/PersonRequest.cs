using MOM.Application.DTOs.Resource.Responses;
using MOM.Application.Infrastructure.Extensions;
using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.Personnel.Requests
{
    public class PersonRequest
    {
        public Guid DtId { get; set; } = Guid.NewGuid();
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
        public PersonWorkStatus WorkStatus { get; set; } = PersonWorkStatus.在职;
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
        public Guid? TeamOfGroupDtId { get; set; }
        /// <summary>
        /// 组织
        /// </summary>
        public Guid? OrgDtId { get; set; }
        /// <summary>
        /// 职位/角色
        /// </summary>
        public IEnumerable<Guid> PositionDtId_List { get; set; } = new List<Guid>();
        /// <summary>
        /// 自定义属性清单
        /// </summary>
        public IEnumerable<ResourcePropertyResponse> Properties { get; set; } = new List<ResourcePropertyResponse>();
        public virtual Person ToPerson()
        {
            Person person = new Person(Id, Name, WorkStatus, Email, PhoneNumber, TeamOfGroupDtId, OrgDtId, PositionDtId_List, Description);
            if (Properties != null)
                foreach (var item in Properties)
                {
                    person.HasValuesOf.Add(new Domain.Common.Relationship.isa95.Person.PersonHasValuesOfRelationship(person, item.ToPersonProperty()));
                }
            return person;
        }
    }
}
