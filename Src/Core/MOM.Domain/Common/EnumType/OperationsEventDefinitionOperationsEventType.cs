namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsEventDefinitionOperationsEventType
    {
        [EnumMember(Value = "event"), Display(Name = "Event")]
        _event,

        [EnumMember(Value = "alert"), Display(Name = "Alert")]
        alert,

        [EnumMember(Value = "Alarm"), Display(Name = "Alarm")]
        Alarm
    }
}