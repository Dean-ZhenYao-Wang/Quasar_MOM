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
        /// 计划中
        /// </summary>
        /// <remarks>
        /// 尚未实际存在，但已分配给生产任务
        /// </remarks>
        [EnumMember(Value = "planned"), Display(Name = "Planned", Description = "尚未实际存在，但已分配给生产任务")]
        planned,

        /// <summary>
        /// 加工中
        /// </summary>
        /// <remarks>
        /// 正在被加工或处理
        /// </remarks>
        [EnumMember(Value = "inProcess"), Display(Name = "in Process", Description = "正在被加工或处理")]
        inProcess,

        /// <summary>
        /// 受限
        /// </summary>
        /// <remarks>
        /// 因质量问题或审批未通过，不能正常使用
        /// </remarks>
        [EnumMember(Value = "restricted"), Display(Name = "Restricted", Description = "因质量问题或审批未通过，不能正常使用")]
        restricted,

        /// <summary>
        /// 正常
        /// </summary>
        /// <remarks>
        /// 可自由使用
        /// </remarks>
        [EnumMember(Value = "unrestricted"), Display(Name = "Unrestricted", Description = "可自由使用")]
        unrestricted,

        /// <summary>
        /// 关闭
        /// </summary>
        /// <remarks>
        /// 已完全消耗、售出或报废
        /// </remarks>
        [EnumMember(Value = "closed"), Display(Name = "Closed", Description = "已完全消耗、售出或报废")]
        closed
    }
}