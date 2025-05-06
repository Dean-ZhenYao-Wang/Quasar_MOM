using System.Collections.Generic;

namespace MOM.Application.DTOs.Account.Responses
{
    public class AuthenticationResponse
    {
        /// <summary>
        /// 工号
        /// </summary>
        public string EmployeeNumber { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 照片路径
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 可访问的菜单及按钮编号清单
        /// </summary>
        public IList<string> Roles { get; set; }
        public string JwToken { get; set; }
    }
}
