namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// ���Ե�����
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ResourceClassPropertyPropertyType
    {
        /// <summary>
        /// ����ֵ��Ϊ�ඨ��ģ�û����ʵ��������ֵ
        /// </summary>
        [EnumMember(Value = "classType"), Display(Name = "Class Type", Description = "����ֵ��Ϊ�ඨ��ģ�û����ʵ��������ֵ")]
        classType,

        /// <summary>
        /// �������ֵδ����
        /// </summary>
        [EnumMember(Value = "instanceType"), Display(Name = "Instance Type", Description = "�������ֵδ����")]
        instanceType,

        /// <summary>
        /// ����ֵ������Ϊ���Ĭ��ʵ��ֵ��������ĸ���ʵ���������¶����ض���ֵ��
        /// </summary>
        [EnumMember(Value = "defaultType"), Display(Name = "Default Type", Description = "����ֵ������Ϊ���Ĭ��ʵ��ֵ��������ĸ���ʵ���������¶����ض���ֵ��")]
        defaultType
    }
}