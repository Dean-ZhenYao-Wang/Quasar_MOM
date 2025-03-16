namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ResourceRelationshipNetworkRelationshipType
    {
        [EnumMember(Value = "physical"), Display(Name = " "), SourceValue(Value = "the elements of the relationship are physically connected or in the same area")]
        physical,

        [EnumMember(Value = "logical"), Display(Name = " "), SourceValue(Value = "the elements of the relationship are not necessarily physically connected or in the same area. ")]
        logical
    }
}