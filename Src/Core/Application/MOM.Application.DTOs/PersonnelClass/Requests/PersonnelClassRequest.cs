using Json.More;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.PersonnelClass.Requests
{
    public class PersonnelClassRequest
    {
        /// <summary>
        /// 名称
        /// </summary>
        public required string Id { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }
        /// <summary>
        /// 权限清单，菜单或按钮的编号
        /// </summary>
        public IEnumerable<string> Permissions { get; set; }
        /// <summary>
        /// 转换成db模型
        /// </summary>
        /// <param name="description">说明-系统内部做业务区分使用的</param>
        /// <returns></returns>
        public Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass ToPersonnelClass(string description)
        {
            Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass personnelClass = new Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass(this.Id, description);
            personnelClass.Remark = this.Remark;

            personnelClass.Permissions.AddRange(this.Permissions
                .Select(m => new Domain.Permission.PersonnelClassPermission()
                {
                    MenuButtonId = m,
                    PersonnelClassDtId = personnelClass.DtId
                }));

            return personnelClass;
        }
    }
}
