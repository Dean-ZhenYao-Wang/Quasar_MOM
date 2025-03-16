namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// ָʾ�洢λ��������ָ����λ�á��豸�������ʲ����󣬻��ǰ����洢λ�õ�������
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MaterialLotStorageLocationType
    {
        /// <summary>
        /// �洢λ���������ò���λ��
        /// </summary>
        [EnumMember(Value = "operationalLocation"), Display(Name = "Operational Location"), SourceValue(Value = "�洢λ���������ò���λ��")]
        operationalLocation,

        /// <summary>
        /// �洢λ�����������豸����
        /// </summary>
        [EnumMember(Value = "equipment"), Display(Name = "Operational Location"), SourceValue(Value = "�洢λ�����������豸����")]
        equipment,

        /// <summary>
        /// �洢λ���������������ʲ�
        /// </summary>
        [EnumMember(Value = "physicalAsset"), Display(Name = "Physical Asset"), SourceValue(Value = "�洢λ���������������ʲ�")]
        physicalAsset,

        /// <summary>
        /// �洢λ�����԰����洢λ�õ�����������ֵ���ַ
        /// </summary>
        [EnumMember(Value = "description"), Display(Name = "Description"), SourceValue(Value = "�洢λ�����԰����洢λ�õ�����������ֵ���ַ")]
        description
    }
}