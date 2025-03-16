namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkPerformanceWorkState
    {
        [EnumMember(Value = "waiting"), Display(Name = " ")]
        waiting,

        [EnumMember(Value = "ready"), Display(Name = " ")]
        ready,

        [EnumMember(Value = "running"), Display(Name = " ")]
        running,

        [EnumMember(Value = "completed"), Display(Name = " ")]
        completed,

        [EnumMember(Value = "aborted"), Display(Name = " ")]
        aborted,

        [EnumMember(Value = "held"), Display(Name = " ")]
        held,

        [EnumMember(Value = "suspended"), Display(Name = " ")]
        suspended,

        [EnumMember(Value = "closed"), Display(Name = " ")]
        closed
    }
}