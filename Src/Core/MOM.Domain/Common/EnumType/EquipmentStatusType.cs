using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.EnumType
{
    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EquipmentStatusType
    {
        /// <summary>
        /// 启用
        /// </summary>
        [EnumMember(Value = "启用"), Display(Name = "启用")]
        启用,

        /// <summary>
        /// 维修
        /// </summary>
        [EnumMember(Value = "维修"), Display(Name = "维修")]
        维修,

        /// <summary>
        /// 故障
        /// </summary>
        [EnumMember(Value = "故障"), Display(Name = "故障")]
        故障,

        /// <summary>
        /// 停用
        /// </summary>
        [EnumMember(Value = "停用"), Display(Name = "停用")]
        停用,

        /// <summary>
        /// 报废
        /// </summary>
        [EnumMember(Value = "报废"), Display(Name = "报废")]
        报废,
    }
}