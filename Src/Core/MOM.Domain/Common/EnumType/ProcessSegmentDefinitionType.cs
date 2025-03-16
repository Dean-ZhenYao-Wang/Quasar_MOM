namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProcessSegmentDefinitionType
    {
        [EnumMember(Value = "pattern"), Display(Name = " ", Description = "a process segment used as a template for other process segments")]
        pattern,

        [EnumMember(Value = "instance"), Display(Name = " ", Description = "a process segment that may be directly scheduled and tracked")]
        instance
    }
}