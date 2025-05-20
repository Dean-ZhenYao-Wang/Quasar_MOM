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
        /// 转换成db模型
        /// </summary>
        /// <returns></returns>
        public virtual Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass ToPersonnelClass(string description)
        {
            Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass personnelClass = new Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass(this.Id,description);
            personnelClass.Remark = this.Remark;
            return personnelClass;
        }
    }
}
