namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialRequirementAssemblyRelationship
    {
        [EnumMember(Value = "permanent"), Display(Name = " ", Description = "an assembly that is not intended to be split during the production process")]
        permanent,

        [EnumMember(Value = "transient"), Display(Name = " ", Description = "a temporary assembly using during production, such as a pallet of different materials or a batch kit")]
        transient
    }
}