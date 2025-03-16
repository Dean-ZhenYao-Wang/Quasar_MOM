namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialSublotDisposition
    {
        [EnumMember(Value = "planned"), Display(Name = "Planned", Description = "a material lot that does not yet physically exist, is assigned to an operations request (segment requirement) or work request (Part 4 object) or job order (Part 4 object)")]
        planned,

        [EnumMember(Value = "inProcess"), Display(Name = "in Process", Description = "the material lot is in the process of being worked on")]
        inProcess,

        [EnumMember(Value = "restricted"), Display(Name = "Restricted", Description = "a material lot is not permitted for normal use due to a restriction condition")]
        restricted,

        [EnumMember(Value = "unrestricted"), Display(Name = "Unrestricted", Description = "material lot is permitted for normal use without restriction")]
        unrestricted,

        [EnumMember(Value = "closed"), Display(Name = "Closed", Description = "material lot has been reconciled as completely consumed, sold or disposed of")]
        closed
    }
}