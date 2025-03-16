namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SegmentRequirementOperationsType
    {
        [EnumMember(Value = "production"), Display(Name = "Production")]
        production,

        [EnumMember(Value = "maintenance"), Display(Name = "Maintenance")]
        maintenance,

        [EnumMember(Value = "quality"), Display(Name = "Quality")]
        quality,

        [EnumMember(Value = "inventory"), Display(Name = "Inventory")]
        inventory,

        [EnumMember(Value = "mixed"), Display(Name = "Mixed"), SourceValue(Value = " can be used when the activity contains several categories of process segments")]
        mixed
    }
}