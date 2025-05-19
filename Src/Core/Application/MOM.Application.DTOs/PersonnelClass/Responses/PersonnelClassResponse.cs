using MOM.Application.DTOs.PersonnelClass.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.PersonnelClass.Responses
{
    public class PersonnelClassResponse:PersonnelClassRequest
    {
        /// <summary>
        /// 数据库唯一主键
        /// </summary>
        public Guid DtId { get; set; }
        /// <summary>
        /// 职位名称
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 权限清单，菜单或按钮的编号
        /// </summary>
        public IEnumerable<string> Permissions { get; set; }
    }
}
