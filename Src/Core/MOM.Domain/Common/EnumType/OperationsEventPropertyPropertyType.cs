namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsEventPropertyPropertyType
    {
        [EnumMember(Value = "classType"), Display(Name = "Class Type", Description = "The property value is defined for the class and there is no value associated with an instance")]
        classType,

        [EnumMember(Value = "instanceType"), Display(Name = "Instance Type", Description = "the property value of the class is undefined")]
        instanceType,

        [EnumMember(Value = "defaultType"), Display(Name = "Default Type", Description = "The property value is defined for the class as the default instance value, but individual instances of the class may redefine specific values.")]
        defaultType
    }
}