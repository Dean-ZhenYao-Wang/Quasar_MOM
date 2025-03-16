namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsSegmentDependencyDependencyType
    {
        [EnumMember(Value = "atStart"), Display(Name = "At start", Description = "start B at A start")]
        atStart,

        [EnumMember(Value = "afterStart"), Display(Name = "After start", Description = "start B after A start")]
        afterStart,

        [EnumMember(Value = "afterEnd"), Display(Name = "After end", Description = "start B after A end")]
        afterEnd,

        [EnumMember(Value = "notFollow"), Display(Name = "Not follow", Description = "B cannot follow A;")]
        notFollow,

        [EnumMember(Value = "possibleParallel"), Display(Name = "Possible parallel", Description = "B may run in parallel to A")]
        possibleParallel,

        [EnumMember(Value = "notInParallel"), Display(Name = "Not in parallel", Description = "B may not run in parallel to A")]
        notInParallel,

        [EnumMember(Value = "noLaterAfterStart"), Display(Name = "No later after start", Description = "start B no later than dependency factor after A start")]
        noLaterAfterStart,

        [EnumMember(Value = "noEarlierAfterStart"), Display(Name = "No earlier after start", Description = "start B no earlier than dependency factor after A start")]
        noEarlierAfterStart,

        [EnumMember(Value = "noLaterAfterEnd"), Display(Name = "No later after end", Description = "start B no later than dependency factor after A end")]
        noLaterAfterEnd,

        [EnumMember(Value = "noEarlierAfterEnd"), Display(Name = "No earlier after end", Description = " B no earlier than dependency factor after A end")]
        noEarlierAfterEnd
    }
}