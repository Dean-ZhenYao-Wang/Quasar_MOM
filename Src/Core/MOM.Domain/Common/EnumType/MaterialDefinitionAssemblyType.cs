namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// ��װ������
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialDefinitionAssemblyType
    {
        [EnumMember(Value = "physical"), Display(Name = " ", Description = "������������ӻ���ͬһ����")]
        physical,

        [EnumMember(Value = "logical"), Display(Name = " ", Description = "��װ�������һ�����������ӻ���ͬһ����")]
        logical
    }
}