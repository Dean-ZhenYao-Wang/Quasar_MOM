namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HierarchyScopeEquipmentLevel
    {
        /// <summary>
        /// ��ҵ
        /// </summary>
        [EnumMember(Value = "Enterprise"), Display(Name = "��ҵ")]
        Enterprise,

        /// <summary>
        /// ����/����
        /// </summary>
        [EnumMember(Value = "Site"), Display(Name = "����/����")]
        Site,

        /// <summary>
        /// ����/����/����
        /// </summary>
        [EnumMember(Value = "Area"), Display(Name = "����/����/����")]
        Area,

        /// <summary>
        /// ��������/CellGroup
        /// </summary>
        [EnumMember(Value = "Work Center"), Display(Name = "��������/CellGroup")]
        Work_Center,

        /// <summary>
        /// ������Ԫ/Cell
        /// </summary>
        [EnumMember(Value = "Work Unit"), Display(Name = "������Ԫ/Cell")]
        Work_Unit,

        /// <summary>
        /// �������նΣ�����������
        /// </summary>
        [EnumMember(Value = "Process Cell"), Display(Name = "�������նΣ�����������")]
        Process_Cell,

        /// <summary>
        /// ��Ԫ���������������豸/���������������豸
        /// </summary>
        [EnumMember(Value = "Unit"), Display(Name = "��Ԫ���������������豸/���������������豸")]
        Unit,

        /// <summary>
        /// ���ߣ������ظ�����ɢ����
        /// </summary>
        [EnumMember(Value = "Production Line"), Display(Name = "���ߣ������ظ�����ɢ����")]
        Production_Line,

        /// <summary>
        /// ����/��λ�������ظ�����ɢ�������豸
        /// </summary>
        [EnumMember(Value = "Production Unit"), Display(Name = "����/��λ�������ظ�����ɢ�������豸")]
        Production_Unit,

        /// <summary>
        /// ������Ԫ��������������
        /// </summary>
        [EnumMember(Value = "Work Cell"), Display(Name = "������Ԫ��������������")]
        Work_Cell,

        /// <summary>
        /// �洢�������ڴ洢������
        /// </summary>
        [EnumMember(Value = "Storage Zone"), Display(Name = "�洢�������ڴ洢������")]
        Storage_Zone,

        /// <summary>
        /// �洢��Ԫ�����ڴ洢��������豸
        /// </summary>
        [EnumMember(Value = "Storage Unit"), Display(Name = "�洢��Ԫ�����ڴ洢��������豸")]
        Storage_Unit
    }
}