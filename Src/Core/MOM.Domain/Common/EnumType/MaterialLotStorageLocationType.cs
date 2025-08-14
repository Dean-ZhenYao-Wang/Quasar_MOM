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
        /// 运营位置
        /// </summary>
        /// <remarks>
        /// 指向一个运营位置（如仓库区、生产线）
        /// </remarks>
        [EnumMember(Value = "operationalLocation"), Display(Name = "Operational Location"), SourceValue(Value = "指向一个运营位置（如仓库区、生产线）")]
        operationalLocation,

        /// <summary>
        /// 设备
        /// </summary>
        /// <remarks>
        /// 存储在某台设备上（如反应釜、烘箱）
        /// </remarks>
        [EnumMember(Value = "equipment"), Display(Name = "Operational Location"), SourceValue(Value = "存储在某台设备上（如反应釜、烘箱）")]
        equipment,

        /// <summary>
        /// 物理资产
        /// </summary>
        /// <remarks>
        /// 存储在某个物理资产上（如托盘、容器）
        /// </remarks>
        [EnumMember(Value = "physicalAsset"), Display(Name = "Physical Asset"), SourceValue(Value = "存储在某个物理资产上（如托盘、容器）")]
        physicalAsset,

        /// <summary>
        /// 描述
        /// </summary>
        /// <remarks>
        /// 仅提供文本描述，如街道地址或库区编号
        /// </remarks>
        [EnumMember(Value = "description"), Display(Name = "Description"), SourceValue(Value = "仅提供文本描述，如街道地址或库区编号")]
        description
    }
}