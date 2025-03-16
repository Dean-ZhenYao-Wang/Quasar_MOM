namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 定义组装关系的类型
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialLotAssemblyRelationship
    {
        /// <summary>
        /// 在生产过程中不打算拆分的组件
        /// </summary>
        [EnumMember(Value = "permanent"), Display(Name = " ", Description = "在生产过程中不打算拆分的组件")]
        permanent,

        /// <summary>
        /// 在生产过程中使用的临时组件，如不同材料的托盘或批处理套件
        /// </summary>
        [EnumMember(Value = "transient"), Display(Name = " ", Description = "在生产过程中使用的临时组件，如不同材料的托盘或批处理套件")]
        transient
    }
}