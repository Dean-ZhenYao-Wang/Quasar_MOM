namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsEventOperationsEventType
    {
        [EnumMember(Value = "event"), Display(Name = "Event")]
        _event,

        [EnumMember(Value = "alert"), Display(Name = "Alert")]
        alert,

        [EnumMember(Value = "alarm"), Display(Name = "Alarm")]
        alarm
    }
}