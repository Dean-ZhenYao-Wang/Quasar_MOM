using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.EnumType
{
    /// <summary>
    /// 工作状态
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PersonWorkStatus
    {
        /// <summary>
        /// 在职
        /// </summary>
        [EnumMember(Value = "在职"), Display(Name = "在职")]
        Employed,

        /// <summary>
        /// 休假
        /// </summary>
        [EnumMember(Value = "休假"), Display(Name = "休假")]
        Vacation,

        /// <summary>
        /// 离职
        /// </summary>
        [EnumMember(Value = "离职"), Display(Name = "离职")]
        Dimission
    }
}