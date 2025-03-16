namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;
    /// <summary>
    /// 所需的属性。可能的值是:生产、维护、质量、库存或混合
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsDefinitionOperationsType
    {
        [EnumMember(Value = "production"), Display(Name = "生产")]
        production,

        [EnumMember(Value = "maintenance"), Display(Name = "维护")]
        maintenance,

        [EnumMember(Value = "quality"), Display(Name = "质量")]
        quality,

        [EnumMember(Value = "inventory"), Display(Name = "库存")]
        inventory,

        [EnumMember(Value = "mixed"), Display(Name = "混合"), SourceValue(Value = "当活动包含多个过程片段类别时可以使用它。")]
        mixed
    }
}