namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;
    /// <summary>
    /// ��������ԡ����ܵ�ֵ��:������ά����������������
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsDefinitionOperationsType
    {
        [EnumMember(Value = "production"), Display(Name = "����")]
        production,

        [EnumMember(Value = "maintenance"), Display(Name = "ά��")]
        maintenance,

        [EnumMember(Value = "quality"), Display(Name = "����")]
        quality,

        [EnumMember(Value = "inventory"), Display(Name = "���")]
        inventory,

        [EnumMember(Value = "mixed"), Display(Name = "���"), SourceValue(Value = "��������������Ƭ�����ʱ����ʹ������")]
        mixed
    }
}