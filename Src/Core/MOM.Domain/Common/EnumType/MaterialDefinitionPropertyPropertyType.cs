namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialDefinitionPropertyPropertyType
    {
        [EnumMember(Value = "classType"), Display(Name = "Class Type", Description = "����ֵ��Ϊ�ඨ��ģ�û����ʵ��������ֵ")]
        classType,

        [EnumMember(Value = "instanceType"), Display(Name = "Instance Type", Description = "�������ֵδ����")]
        instanceType,

        [EnumMember(Value = "defaultType"), Display(Name = "Default Type", Description = "����ֵ������Ϊ���Ĭ��ʵ��ֵ��������ĸ���ʵ���������¶����ض���ֵ��")]
        defaultType
    }
}