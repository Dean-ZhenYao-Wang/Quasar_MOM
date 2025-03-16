namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum JobOrderWorkType
    {
        [EnumMember(Value = "production"), Display(Name = " ")]
        production,

        [EnumMember(Value = "maintenance"), Display(Name = " ")]
        maintenance,

        [EnumMember(Value = "quality"), Display(Name = " ")]
        quality,

        [EnumMember(Value = "inventory"), Display(Name = " ")]
        inventory,

        [EnumMember(Value = "mixed"), Display(Name = " "), SourceValue(Value = " can be used when the activity contains several categories")]
        mixed
    }
}