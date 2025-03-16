namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 一个物料批次或物料批次组装的计划和物流处置。
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialLotDisposition
    {
        /// <summary>
        /// 一个尚未实际存在的物料批次，被分配给一个操作请求(分段需求)或工作请求(第4部分对象)或工作订单(第4部分对象)。
        /// </summary>
        [EnumMember(Value = "planned"), Display(Name = "Planned", Description = "一个尚未实际存在的物料批次，被分配给一个操作请求(分段需求)或工作请求(第4部分对象)或工作订单(第4部分对象)。")]
        planned,

        /// <summary>
        /// 这批材料正在加工中
        /// </summary>
        [EnumMember(Value = "inProcess"), Display(Name = "in Process", Description = "这批材料正在加工中")]
        inProcess,

        /// <summary>
        /// 某批物料因限制条件不允许正常使用
        /// </summary>
        [EnumMember(Value = "restricted"), Display(Name = "Restricted", Description = "某批物料因限制条件不允许正常使用")]
        restricted,

        /// <summary>
        /// 材料批允许正常使用，不受限制
        /// </summary>
        [EnumMember(Value = "unrestricted"), Display(Name = "Unrestricted", Description = "材料批允许正常使用，不受限制")]
        unrestricted,

        /// <summary>
        /// 物料已被核对为完全消耗、售出或处置
        /// </summary>
        [EnumMember(Value = "closed"), Display(Name = "Closed", Description = "物料已被核对为完全消耗、售出或处置")]
        closed
    }
}