namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 操作位置类型
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PersonOperationalLocationType
    {
        /// <summary>
        /// 操作位置属性引用操作位置;
        /// </summary>
        [EnumMember(Value = "operationalLocation"), Display(Name = "Operational Location", Description = "操作位置属性引用操作位置;")]
        operationalLocation,

        /// <summary>
        /// 操作位置属性包含操作位置的描述，例如街道地址。
        /// </summary>
        [EnumMember(Value = "description"), Display(Name = "Description", Description = "操作位置属性包含操作位置的描述，例如街道地址。")]
        description
    }
}