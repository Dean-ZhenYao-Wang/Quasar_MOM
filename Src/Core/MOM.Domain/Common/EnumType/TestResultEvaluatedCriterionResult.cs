namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TestResultEvaluatedCriterionResult
    {
        [EnumMember(Value = "pass"), Display(Name = "Pass")]
        pass,

        [EnumMember(Value = "fail"), Display(Name = "Fail")]
        fail,

        [EnumMember(Value = "warn"), Display(Name = "Warn")]
        warn,

        [EnumMember(Value = "other"), Display(Name = "Other"), SourceValue(Value = "See additional property 'otherEvaluatedCriterionResult'")]
        other
    }
}