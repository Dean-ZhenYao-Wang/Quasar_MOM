namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsEventDefinitionMomFunction
    {
        [EnumMember(Value = "resourceManagement"), Display(Name = "Resource management")]
        resourceManagement,

        [EnumMember(Value = "definitionManagement"), Display(Name = "Definition management")]
        definitionManagement,

        [EnumMember(Value = "detailedScheduling"), Display(Name = "Detailed scheduling")]
        detailedScheduling,

        [EnumMember(Value = "dispatching"), Display(Name = "Dispatching")]
        dispatching,

        [EnumMember(Value = "executionManagement"), Display(Name = "Execution management")]
        executionManagement,

        [EnumMember(Value = "dataCollection"), Display(Name = "Data collection")]
        dataCollection,

        [EnumMember(Value = "performanceAnalysis"), Display(Name = "Performance analysis")]
        performanceAnalysis,

        [EnumMember(Value = "tracking"), Display(Name = "Tracking")]
        tracking
    }
}