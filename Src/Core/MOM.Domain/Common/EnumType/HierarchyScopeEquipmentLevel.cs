namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HierarchyScopeEquipmentLevel
    {
        /// <summary>
        /// 企业
        /// </summary>
        [EnumMember(Value = "Enterprise"), Display(Name = "企业")]
        Enterprise,

        /// <summary>
        /// 场所/工厂
        /// </summary>
        [EnumMember(Value = "Site"), Display(Name = "场所/工厂")]
        Site,

        /// <summary>
        /// 区域/车间/部门
        /// </summary>
        [EnumMember(Value = "Area"), Display(Name = "区域/车间/部门")]
        Area,

        /// <summary>
        /// 工作中心/CellGroup
        /// </summary>
        [EnumMember(Value = "Work Center"), Display(Name = "工作中心/CellGroup")]
        Work_Center,

        /// <summary>
        /// 工作单元/Cell
        /// </summary>
        [EnumMember(Value = "Work Unit"), Display(Name = "工作单元/Cell")]
        Work_Unit,

        /// <summary>
        /// 生产工艺段：用于批生产
        /// </summary>
        [EnumMember(Value = "Process Cell"), Display(Name = "生产工艺段：用于批生产")]
        Process_Cell,

        /// <summary>
        /// 单元：用于批生产的设备/用于连续生产的设备
        /// </summary>
        [EnumMember(Value = "Unit"), Display(Name = "单元：用于批生产的设备/用于连续生产的设备")]
        Unit,

        /// <summary>
        /// 产线：用于重复或离散生产
        /// </summary>
        [EnumMember(Value = "Production Line"), Display(Name = "产线：用于重复或离散生产")]
        Production_Line,

        /// <summary>
        /// 工段/工位：用于重复或离散生产的设备
        /// </summary>
        [EnumMember(Value = "Production Unit"), Display(Name = "工段/工位：用于重复或离散生产的设备")]
        Production_Unit,

        /// <summary>
        /// 生产单元：用于连续生产
        /// </summary>
        [EnumMember(Value = "Work Cell"), Display(Name = "生产单元：用于连续生产")]
        Work_Cell,

        /// <summary>
        /// 存储区：用于存储或运输
        /// </summary>
        [EnumMember(Value = "Storage Zone"), Display(Name = "存储区：用于存储或运输")]
        Storage_Zone,

        /// <summary>
        /// 存储单元：用于存储或运输的设备
        /// </summary>
        [EnumMember(Value = "Storage Unit"), Display(Name = "存储单元：用于存储或运输的设备")]
        Storage_Unit
    }
}