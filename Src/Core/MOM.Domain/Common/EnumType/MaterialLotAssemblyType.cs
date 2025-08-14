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
        /// 物理连接或位于同一区域
        /// </summary>
        [EnumMember(Value = "physical"), Display(Name = " ", Description = "物理连接或位于同一区域")]
        physical,

        /// <summary>
        /// 逻辑组合，无需物理连接
        /// </summary>
        [EnumMember(Value = "logical"), Display(Name = " ", Description = "逻辑组合，无需物理连接")]
        logical
    }
}