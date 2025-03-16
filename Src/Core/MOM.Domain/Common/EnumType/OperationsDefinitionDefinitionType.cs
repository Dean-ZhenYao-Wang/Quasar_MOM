namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// �������������
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsDefinitionDefinitionType
    {
        [EnumMember(Value = "pattern"), Display(Name = " ", Description = "��Ϊ������������ģ��ʹ�õĲ�������")]
        pattern,

        [EnumMember(Value = "instance"), Display(Name = " ", Description = "����ֱ�Ӱ��ź͸��ٵĲ�������")]
        instance
    }
}