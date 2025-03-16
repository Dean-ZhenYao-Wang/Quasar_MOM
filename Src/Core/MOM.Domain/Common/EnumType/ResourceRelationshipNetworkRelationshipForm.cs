namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ResourceRelationshipNetworkRelationshipForm
    {
        [EnumMember(Value = "permanent"), Display(Name = " "), SourceValue(Value = "the relationship is not intended to be split or changed during operations processes;")]
        permanent,

        [EnumMember(Value = "transient"), Display(Name = " "), SourceValue(Value = "the elements of the relationship are not necessarily physically connected or in the same area. ")]
        transient
    }
}