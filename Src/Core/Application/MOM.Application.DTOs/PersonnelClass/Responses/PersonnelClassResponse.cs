using MOM.Application.DTOs.PersonnelClass.Requests;

namespace MOM.Application.DTOs.PersonnelClass.Responses
{
    public class PersonnelClassResponse : PersonnelClassRequest
    {
        /// <summary>
        /// 数据库唯一主键
        /// </summary>
        public Guid DtId { get; set; }

        /// <summary>
        /// 权限清单，菜单或按钮的编号
        /// </summary>
        public IEnumerable<string> Permissions { get; set; }
    }
}