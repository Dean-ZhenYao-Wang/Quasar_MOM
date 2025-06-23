namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 物理位置类型
    /// </summary>
    /// <remarks>
    /// 标识物理位置属性引用的是操作位置对象还是包含位置描述
    /// </remarks>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhysicalAssetPhysicalLocationType
    {
        /// <summary>
        /// 操作位置
        /// </summary>
        /// <remarks>
        /// 物理位置属性引用操作位置对象
        /// </remarks>
        [EnumMember(Value = "operationalLocation"), Display(Name = "operationalLocation", Description = "物理位置属性引用操作位置对象")]
        operationalLocation,

        /// <summary>
        /// 描述
        /// </summary>
        /// <remarks>
        /// 物理位置属性包含位置描述（如街道地址）
        /// </remarks>
        [EnumMember(Value = "description"), Display(Name = "description", Description = "物理位置属性包含位置描述（如街道地址）")]
        description
    }
}