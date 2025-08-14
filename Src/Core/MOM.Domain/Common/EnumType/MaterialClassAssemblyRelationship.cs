namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 装配关系的类型
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialClassAssemblyRelationship
    {
        /// <summary>
        /// 永久装配
        /// </summary>
        /// <remarks>
        /// 在生产过程中不打算拆分的装配体，如最终产品或固定模块。
        /// </remarks>
        [EnumMember(Value = "permanent"), Display(Name = " ", Description = "在生产过程中不打算拆分的装配体，如最终产品或固定模块。")]
        permanent,
        /// <summary>
        /// 临时装配
        /// </summary>
        /// <remarks>
        /// 仅在生产过程中短暂存在的组合，例如装有多种物料的托盘、批次套件（batch kit）等。
        /// </remarks>
        [EnumMember(Value = "transient"), Display(Name = " ", Description = "仅在生产过程中短暂存在的组合，例如装有多种物料的托盘、批次套件（batch kit）等。")]
        transient
    }
}