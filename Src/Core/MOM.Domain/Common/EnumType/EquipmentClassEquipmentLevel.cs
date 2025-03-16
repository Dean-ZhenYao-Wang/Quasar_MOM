namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EquipmentClassEquipmentLevel
    {
        /// <summary>
        /// 企业
        /// </summary>
        [EnumMember(Value = "Enterprise"), Display(Name = "Enterprise")]
        Enterprise,

        /// <summary>
        /// 场所/工厂
        /// </summary>
        [EnumMember(Value = "Site"), Display(Name = "Site")]
        Site,

        /// <summary>
        /// 区域/车间
        /// </summary>
        [EnumMember(Value = "Area"), Display(Name = "Area")]
        Area,

        /// <summary>
        /// 工作中心/CellGroup
        /// </summary>
        [EnumMember(Value = "Work Center"), Display(Name = "Work Center")]
        Work_Center,

        /// <summary>
        /// 工作单元/Cell
        /// </summary>
        [EnumMember(Value = "Work Unit"), Display(Name = "Work Unit")]
        Work_Unit,

        /// <summary>
        /// 生产工艺段：用于批生产
        /// </summary>
        [EnumMember(Value = "Process Cell"), Display(Name = "Process Cell")]
        Process_Cell,

        /// <summary>
        /// 单元：用于批生产的设备/用于连续生产的设备
        /// </summary>
        [EnumMember(Value = "Unit"), Display(Name = "Unit")]
        Unit,

        /// <summary>
        /// 产线：用于重复或离散生产
        /// </summary>
        [EnumMember(Value = "Production Line"), Display(Name = "Production Line")]
        Production_Line,

        /// <summary>
        /// 工段/工位：用于重复或离散生产的设备
        /// </summary>
        [EnumMember(Value = "Production Unit"), Display(Name = "Production Unit")]
        Production_Unit,

        /// <summary>
        /// 生产单元：用于连续生产
        /// </summary>
        [EnumMember(Value = "Work Cell"), Display(Name = "Work Cell")]
        Work_Cell,

        /// <summary>
        /// 存储区：用于存储或运输
        /// </summary>
        [EnumMember(Value = "Storage Zone"), Display(Name = "Storage Zone")]
        Storage_Zone,

        /// <summary>
        /// 存储单元：用于存储或运输的设备
        /// </summary>
        [EnumMember(Value = "Storage Unit"), Display(Name = "Storage Unit")]
        Storage_Unit
    }
}