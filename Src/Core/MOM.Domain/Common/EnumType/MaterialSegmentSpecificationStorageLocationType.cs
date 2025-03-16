namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialSegmentSpecificationStorageLocationType
    {
        [EnumMember(Value = "operationalLocation"), Display(Name = "Operational Location"), SourceValue(Value = "storage location attribute references an operational location")]
        operationalLocation,

        [EnumMember(Value = "equipment"), Display(Name = "Operational Location"), SourceValue(Value = "storage location attribute references an equipment object")]
        equipment,

        [EnumMember(Value = "physicalAsset"), Display(Name = "Physical Asset"), SourceValue(Value = " storage location attribute references a physical asset")]
        physicalAsset,

        [EnumMember(Value = "description"), Display(Name = "Description"), SourceValue(Value = "storage location attribute contains a description of the storage location, such as a street address")]
        description
    }
}