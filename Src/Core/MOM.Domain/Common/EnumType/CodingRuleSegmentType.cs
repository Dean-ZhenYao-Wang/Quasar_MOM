namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// ���������ö��
    /// ������������ÿ���ε�������Դ����
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CodingRuleSegmentType
    {
        /// <summary>
        /// �̶�ֵ��
        /// �öε�ֵ��Ԥ���趨�Ĺ̶��ַ���������仯
        /// ���磺����ǰ׺ "PRD"��"ORD" ��
        /// </summary>
        [EnumMember(Value = "Fixed"), Display(Name = "�̶�ֵ")]
        Fixed,

        /// <summary>
        /// ģ�����Զ�
        /// �öε�ֵ��Դ��EF Coreģ�͵�ĳ������
        /// ���磺��Ʒ��𡢿ͻ������
        /// </summary>
        [EnumMember(Value = "Property"), Display(Name = "ģ������")]
        Property,

        /// <summary>
        /// ���кŶ�
        /// �öε�ֵ���Զ����������к�
        /// ֧�ֶ�����������У�ÿ�����п����в�ͬ�����ƺ���ʼֵ
        /// </summary>
        [EnumMember(Value = "Sequence"), Display(Name = "���к�")]
        Sequence,

        /// <summary>
        /// ����ʱ���
        /// �öε�ֵ���ڵ�ǰ����ʱ������
        /// ֧���Զ�������ʱ���ʽ���� "yyyyMMdd"��"HHmmss" ��
        /// </summary>
        [EnumMember(Value = "DateTime"), Display(Name = "����ʱ��")]
        DateTime,

        /// <summary>
        /// �Զ����߼���
        /// �öε�ֵͨ���Զ����߼�����
        /// ��ͨ���̳�ICodingRuleManager����дProcessCustomSegment����ʵ��
        /// </summary>
        [EnumMember(Value = "Custom"), Display(Name = "�Զ����߼�")]
        Custom
    }
}