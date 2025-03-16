namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EquipmentCapabilityOperationalLocationType
    {
        [EnumMember(Value = "operationalLocation"), Display(Name = "Operational Location", Description = "operational location attribute references an operational location;")]
        operationalLocation,

        [EnumMember(Value = "description"), Display(Name = "Description", Description = "operational location attribute contains a description of the operational location, such as a street address.")]
        description
    }
}