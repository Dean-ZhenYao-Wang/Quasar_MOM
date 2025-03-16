namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsEventOperationsEventLevel
    {
        [EnumMember(Value = "3"), Display(Name = "Level 3")]
        _3,

        [EnumMember(Value = "4"), Display(Name = "Level 4")]
        _4
    }
}