﻿using MOM.Application.DTOs.Personnel.Requests;
using MOM.Domain.Common.EnumType;
using MOM.Domain.Permission;
using System.Text.Json.Serialization;

namespace MOM.Application.DTOs.Personnel.Responses
{
    public class PersonResponse
    {
        /// <summary>
        /// 当前人员的数据库唯一key，如果是新增人员则无需传递此字段的值
        /// </summary>
        public Guid DtId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// UserName 账号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 在职\休假\离职
        /// </summary>
        public PersonWorkStatus WorkStatus { get; set; } = PersonWorkStatus.Employed;

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
        [JsonIgnore]
        public ResponseObject Team { get; set; }
        /// <summary>
        /// 班组
        /// </summary>
        public string? TeamName { get { return Team?.Label; } }
        /// <summary>
        /// 班组唯一标识
        /// </summary>
        public Guid? TeamDtId { get { return Team?.DtId; } }
        /// <summary>
        /// 职位/角色
        /// </summary>
        [JsonIgnore]
        public IEnumerable<ResponseObject> PositionList { get; set; } = new List<ResponseObject>();
        /// <summary>
        /// 职位/角色的名称
        /// </summary>
        public string Position
        {
            get
            {
                return PositionList.Count() > 0 ? PositionList.Select(m => m.Label).Aggregate((a, b) => a + "、" + b) : string.Empty; // 顿号分隔
            }
        }
        /// <summary>
        /// 职位/角色
        /// </summary>
        public IEnumerable<Guid> PositionDtId_List
        {
            get { return PositionList.Count() > 0 ? PositionList.Where(m => m.DtId != null).Select(m => m.DtId.Value) : new List<Guid>(); }
        }
        /// <summary>
        /// 组织
        /// </summary>
        public ResponseObject Org { get; set; }
        /// <summary>
        /// 组织
        /// </summary>
        public Guid? OrgDtId { get { return Org?.DtId; } }
        /// <summary>
        /// 组织
        /// </summary>
        public string? OrgName { get { return Org?.Label; } }
        /// <summary>
        /// 具有的权限清单
        /// </summary>
        public IEnumerable<string> Permissions
        {
            get
            {
                return DefinedByPermissions
                    .Union(HierarchyScopeRelPermissions)
                    .Union(AvailablePermissions.Where(m => m.Available).Select(m => m.MenuButtonId))
                    .Except(AvailablePermissions.Where(m => m.Available == false).Select(m => m.MenuButtonId))
                    .Distinct()
                    .ToList();
            }
        }
        /// <summary>
        /// 所属人员类权限清单
        /// </summary>
        [JsonIgnore]
        public IEnumerable<string> DefinedByPermissions { get; set; } = new List<string>();
        /// <summary>
        /// 所属组织权限清单
        /// </summary>
        [JsonIgnore]
        public IEnumerable<string> HierarchyScopeRelPermissions { get; set; } = new List<string>();
        /// <summary>
        /// 当前人的特殊权限
        /// </summary>
        [JsonIgnore]
        public IEnumerable<AvailablePerm> AvailablePermissions { get; set; } = new List<AvailablePerm>();
    }
    public class AvailablePerm
    {
        public bool Available { get; set; }
        public string MenuButtonId { get; set; }
    }
}