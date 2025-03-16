namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PersonnelCapabilityCapabilityType
    {
        [EnumMember(Value = "committed"), Display(Name = " "), SourceValue(Value = ": capacity that is committed for future productive use.")]
        committed,

        [EnumMember(Value = "unattainable"), Display(Name = " "), SourceValue(Value = "capacity that is not attainable for future productive use given the equipment condition, equipment utilization, personnel availability or material availability.")]
        unattainable,

        [EnumMember(Value = "available"), Display(Name = " "), SourceValue(Value = "capacity that is available for additional future productive use.")]
        available,

        [EnumMember(Value = "used"), Display(Name = " "), SourceValue(Value = "a historical value that defines the portion of the capacity with acceptable quality.")]
        used,

        [EnumMember(Value = "unused"), Display(Name = " "), SourceValue(Value = " a historical value that defines the portion of the capacity that was not used or had unacceptable quality.")]
        unused,

        [EnumMember(Value = "total"), Display(Name = " "), SourceValue(Value = "the sum of used and unused capability or the sum of available, unattainable and committed capability.")]
        total
    }
}