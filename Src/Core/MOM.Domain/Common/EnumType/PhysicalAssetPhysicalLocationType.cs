namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// ����λ������
    /// </summary>
    /// <remarks>
    /// ��ʶ����λ���������õ��ǲ���λ�ö����ǰ���λ������
    /// </remarks>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhysicalAssetPhysicalLocationType
    {
        /// <summary>
        /// ����λ��
        /// </summary>
        /// <remarks>
        /// ����λ���������ò���λ�ö���
        /// </remarks>
        [EnumMember(Value = "operationalLocation"), Display(Name = "operationalLocation", Description = "����λ���������ò���λ�ö���")]
        operationalLocation,

        /// <summary>
        /// ����
        /// </summary>
        /// <remarks>
        /// ����λ�����԰���λ����������ֵ���ַ��
        /// </remarks>
        [EnumMember(Value = "description"), Display(Name = "description", Description = "����λ�����԰���λ����������ֵ���ַ��")]
        description
    }
}