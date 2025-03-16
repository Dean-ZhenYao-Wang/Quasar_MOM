namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsSegmentDefinitionType
    {
        [EnumMember(Value = "pattern"), Display(Name = " ", Description = "a operations segment used as a template for other operations segments")]
        pattern,

        [EnumMember(Value = "instance"), Display(Name = " ", Description = "a operations segment that may be directly scheduled and tracked")]
        instance
    }
}