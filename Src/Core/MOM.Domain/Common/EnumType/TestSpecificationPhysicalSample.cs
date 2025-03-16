namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TestSpecificationPhysicalSample
    {
        [EnumMember(Value = "yes"), Display(Name = "Yes", Description = "physical samples are required")]
        yes,

        [EnumMember(Value = "no"), Display(Name = "No", Description = "physical samples are not required")]
        no
    }
}