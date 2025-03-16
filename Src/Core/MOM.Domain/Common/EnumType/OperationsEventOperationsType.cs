namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsEventOperationsType
    {
        [EnumMember(Value = "production"), Display(Name = "Production")]
        production,

        [EnumMember(Value = "inventory"), Display(Name = "Inventory")]
        inventory,

        [EnumMember(Value = "quality"), Display(Name = "Quality")]
        quality,

        [EnumMember(Value = "maintenance"), Display(Name = "Maintenance")]
        maintenance,

        [EnumMember(Value = "mixed"), Display(Name = "Mixed"), SourceValue(Value = "Mixed can be used when the operations event does not refer to a specific operations activity or refers to several operation activities")]
        mixed
    }
}