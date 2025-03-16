namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsMaterialBillUseType
    {
        [EnumMember(Value = "consumed"), Display(Name = "Consumed", Description = "indicates that operations material bill items are all consumed material.")]
        consumed,

        [EnumMember(Value = "produced"), Display(Name = "Produced", Description = "indicates that operations material bill items are all produced materials. ")]
        produced,

        [EnumMember(Value = "mixed"), Display(Name = "Mixed", Description = "indicates that operations material bill items are both consumed and produced materials. ")]
        mixed
    }
}