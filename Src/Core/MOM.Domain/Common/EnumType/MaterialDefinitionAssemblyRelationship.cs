namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// ��װ��ϵ������
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialDefinitionAssemblyRelationship
    {
        [EnumMember(Value = "permanent"), Display(Name = " ", Description = "�����������в������ֵ����")]
        permanent,

        [EnumMember(Value = "transient"), Display(Name = " ", Description = "������������ʹ�õ���ʱ������粻ͬ���ϵ����̻��������׼�")]
        transient
    }
}