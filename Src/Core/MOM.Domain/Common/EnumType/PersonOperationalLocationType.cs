namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// ����λ������
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PersonOperationalLocationType
    {
        /// <summary>
        /// ����λ���������ò���λ��;
        /// </summary>
        [EnumMember(Value = "operationalLocation"), Display(Name = "Operational Location", Description = "����λ���������ò���λ��;")]
        operationalLocation,

        /// <summary>
        /// ����λ�����԰�������λ�õ�����������ֵ���ַ��
        /// </summary>
        [EnumMember(Value = "description"), Display(Name = "Description", Description = "����λ�����԰�������λ�õ�����������ֵ���ַ��")]
        description
    }
}