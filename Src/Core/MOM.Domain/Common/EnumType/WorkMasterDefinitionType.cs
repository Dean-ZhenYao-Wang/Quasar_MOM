namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkMasterDefinitionType
    {
        [EnumMember(Value = "pattern"), Display(Name = " "), SourceValue(Value = "a work master used as a template for other work masters.")]
        pattern,

        [EnumMember(Value = "instance"), Display(Name = " "), SourceValue(Value = ": a work master directly scheduled, dispatched and executed.")]
        instance
    }
}