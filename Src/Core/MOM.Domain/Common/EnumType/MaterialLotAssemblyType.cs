namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 定义组装类型
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialLotAssemblyType
    {
        /// <summary>
        /// 组件的物理连接或在同一区域
        /// </summary>
        [EnumMember(Value = "physical"), Display(Name = " ", Description = "组件的物理连接或在同一区域")]
        physical,

        /// <summary>
        /// 组装的组件不一定是物理连接或在同一区域
        /// </summary>
        [EnumMember(Value = "logical"), Display(Name = " ", Description = "组装的组件不一定是物理连接或在同一区域")]
        logical
    }
}