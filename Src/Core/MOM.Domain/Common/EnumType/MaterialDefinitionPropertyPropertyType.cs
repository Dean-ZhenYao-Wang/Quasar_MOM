namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialDefinitionPropertyPropertyType
    {
        [EnumMember(Value = "classType"), Display(Name = "Class Type", Description = "属性值是为类定义的，没有与实例关联的值")]
        classType,

        [EnumMember(Value = "instanceType"), Display(Name = "Instance Type", Description = "类的属性值未定义")]
        instanceType,

        [EnumMember(Value = "defaultType"), Display(Name = "Default Type", Description = "属性值被定义为类的默认实例值，但是类的各个实例可以重新定义特定的值。")]
        defaultType
    }
}