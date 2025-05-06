using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Domain.Common
{
    /// <summary>
    /// 联系方式
    /// </summary>
    [Owned]
    public record ContactInformation
    {
        /// <summary>
        /// 联系电话
        /// </summary>
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string? Email { get; set; }
    }
}
