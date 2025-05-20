using Microsoft.EntityFrameworkCore;

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