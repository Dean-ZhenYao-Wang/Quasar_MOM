using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.EnumType
{
    /// <summary>
    /// 性别
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GenderType
    {
        /// <summary>
        /// 男
        /// </summary>
        [EnumMember(Value = "男"), Display(Name = "男")]
        Male,
        /// <summary>
        /// 女
        /// </summary>
        [EnumMember(Value = "女"), Display(Name = "女")]
        Female,
        /// <summary>
        /// 未知
        /// </summary>
        [EnumMember(Value = "未知"), Display(Name = "未知")]
        Unknown
    }
}
