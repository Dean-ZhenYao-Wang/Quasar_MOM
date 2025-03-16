namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsRecordSpecificationTemplateAction
    {
        [EnumMember(Value = "added"), Display(Name = " ")]
        added,

        [EnumMember(Value = "changed"), Display(Name = " ")]
        changed,

        [EnumMember(Value = "deleted"), Display(Name = " ")]
        deleted,

        [EnumMember(Value = "observed"), Display(Name = " ")]
        observed
    }
}