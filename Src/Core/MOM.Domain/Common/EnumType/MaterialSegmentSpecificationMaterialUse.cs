namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialSegmentSpecificationMaterialUse
    {
        [EnumMember(Value = "consumable"), Display(Name = "Consumable")]
        consumable,

        [EnumMember(Value = "materialConsumed"), Display(Name = "Material consumed")]
        materialConsumed,

        [EnumMember(Value = "materialProduced"), Display(Name = "Material produced")]
        materialProduced,

        [EnumMember(Value = "byProductProduced"), Display(Name = "By-Product produced")]
        byProductProduced,

        [EnumMember(Value = "coProductProduced"), Display(Name = "Co-Product produced")]
        coProductProduced,

        [EnumMember(Value = "yieldProduced"), Display(Name = "Yield produced")]
        yieldProduced,

        [EnumMember(Value = "destructiveSample"), Display(Name = "Destructive sample")]
        destructiveSample,

        [EnumMember(Value = "returnedSample"), Display(Name = "Returned sample")]
        returnedSample,

        [EnumMember(Value = "retainedSample"), Display(Name = "Retained sample")]
        retainedSample,

        [EnumMember(Value = "inventoried"), Display(Name = "Inventoried")]
        inventoried
    }
}