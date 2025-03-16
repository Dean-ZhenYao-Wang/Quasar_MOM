namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 指示存储位置属性是指操作位置、设备或物理资产对象，还是包含存储位置的描述。
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialLotStorageLocationType
    {
        /// <summary>
        /// 存储位置属性引用操作位置
        /// </summary>
        [EnumMember(Value = "operationalLocation"), Display(Name = "Operational Location"), SourceValue(Value = "存储位置属性引用操作位置")]
        operationalLocation,

        /// <summary>
        /// 存储位置属性引用设备对象
        /// </summary>
        [EnumMember(Value = "equipment"), Display(Name = "Operational Location"), SourceValue(Value = "存储位置属性引用设备对象")]
        equipment,

        /// <summary>
        /// 存储位置属性引用物理资产
        /// </summary>
        [EnumMember(Value = "physicalAsset"), Display(Name = "Physical Asset"), SourceValue(Value = "存储位置属性引用物理资产")]
        physicalAsset,

        /// <summary>
        /// 存储位置属性包含存储位置的描述，例如街道地址
        /// </summary>
        [EnumMember(Value = "description"), Display(Name = "Description"), SourceValue(Value = "存储位置属性包含存储位置的描述，例如街道地址")]
        description
    }
}