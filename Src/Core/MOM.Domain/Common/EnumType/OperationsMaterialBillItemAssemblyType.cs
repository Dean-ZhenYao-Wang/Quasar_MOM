namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsMaterialBillItemAssemblyType
    {
        [EnumMember(Value = "physical"), Display(Name = " ", Description = "the components of the assembly are physically connected or in the same area")]
        physical,

        [EnumMember(Value = "logical"), Display(Name = " ", Description = "the components of the assembly are not necessarily physically connected or in the same area")]
        logical
    }
}