namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 组装的类型
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialClassAssemblyType
    {
        /// <summary>
        /// 物理装配
        /// </summary>
        /// <remarks>
        /// 组件之间存在实际物理连接或位于同一区域，如焊接组件或固定在托盘上的部件。
        /// </remarks>
        [EnumMember(Value = "physical"), Display(Name = " ", Description = "组件之间存在实际物理连接或位于同一区域，如焊接组件或固定在托盘上的部件。")]
        physical,

        /// <summary>
        /// 逻辑装配
        /// </summary>
        /// <remarks>
        /// 组件无需物理连接或处于同一区域，仅为逻辑上的组合，如订单配套包或虚拟BOM结构。
        /// </remarks>

        [EnumMember(Value = "logical"), Display(Name = " ", Description = "组件无需物理连接或处于同一区域，仅为逻辑上的组合，如订单配套包或虚拟BOM结构。")]
        logical
    }
}