namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// һ���������λ�����������װ�ļƻ����������á�
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialLotDisposition
    {
        /// <summary>
        /// һ����δʵ�ʴ��ڵ��������Σ��������һ����������(�ֶ�����)��������(��4���ֶ���)��������(��4���ֶ���)��
        /// </summary>
        [EnumMember(Value = "planned"), Display(Name = "Planned", Description = "һ����δʵ�ʴ��ڵ��������Σ��������һ����������(�ֶ�����)��������(��4���ֶ���)��������(��4���ֶ���)��")]
        planned,

        /// <summary>
        /// �����������ڼӹ���
        /// </summary>
        [EnumMember(Value = "inProcess"), Display(Name = "in Process", Description = "�����������ڼӹ���")]
        inProcess,

        /// <summary>
        /// ĳ��������������������������ʹ��
        /// </summary>
        [EnumMember(Value = "restricted"), Display(Name = "Restricted", Description = "ĳ��������������������������ʹ��")]
        restricted,

        /// <summary>
        /// ��������������ʹ�ã���������
        /// </summary>
        [EnumMember(Value = "unrestricted"), Display(Name = "Unrestricted", Description = "��������������ʹ�ã���������")]
        unrestricted,

        /// <summary>
        /// �����ѱ��˶�Ϊ��ȫ���ġ��۳�����
        /// </summary>
        [EnumMember(Value = "closed"), Display(Name = "Closed", Description = "�����ѱ��˶�Ϊ��ȫ���ġ��۳�����")]
        closed
    }
}