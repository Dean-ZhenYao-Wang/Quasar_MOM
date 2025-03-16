namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkflowSpecificationDefinitionType
    {
        [EnumMember(Value = "pattern"), Display(Name = " ", Description = "a Workflow specification used as a template for other Workflow specifications")]
        pattern,

        [EnumMember(Value = "instance"), Display(Name = " ", Description = "a Workflow specification that may be directly scheduled and tracked")]
        instance
    }
}