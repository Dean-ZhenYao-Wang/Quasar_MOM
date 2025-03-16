namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 操作定义的类型
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsDefinitionDefinitionType
    {
        [EnumMember(Value = "pattern"), Display(Name = " ", Description = "作为其他操作定义模板使用的操作定义")]
        pattern,

        [EnumMember(Value = "instance"), Display(Name = " ", Description = "可以直接安排和跟踪的操作定义")]
        instance
    }
}