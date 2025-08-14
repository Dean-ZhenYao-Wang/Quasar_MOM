namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 定义组装关系的类型
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialLotAssemblyRelationship
    {
        /// <summary>
        /// 永久装配，不打算拆分
        /// </summary>
        [EnumMember(Value = "permanent"), Display(Name = " ", Description = "永久装配，不打算拆分")]
        permanent,

        /// <summary>
        /// 临时装配，如托盘组合、批次套件
        /// </summary>
        [EnumMember(Value = "transient"), Display(Name = " ", Description = "临时装配，如托盘组合、批次套件")]
        transient
    }
}