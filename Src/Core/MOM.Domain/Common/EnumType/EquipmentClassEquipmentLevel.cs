namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EquipmentClassEquipmentLevel
    {
        /// <summary>
        /// ��ҵ
        /// </summary>
        [EnumMember(Value = "Enterprise"), Display(Name = "Enterprise")]
        Enterprise,

        /// <summary>
        /// ����/����
        /// </summary>
        [EnumMember(Value = "Site"), Display(Name = "Site")]
        Site,

        /// <summary>
        /// ����/����
        /// </summary>
        [EnumMember(Value = "Area"), Display(Name = "Area")]
        Area,

        /// <summary>
        /// ��������/CellGroup
        /// </summary>
        [EnumMember(Value = "Work Center"), Display(Name = "Work Center")]
        Work_Center,

        /// <summary>
        /// ������Ԫ/Cell
        /// </summary>
        [EnumMember(Value = "Work Unit"), Display(Name = "Work Unit")]
        Work_Unit,

        /// <summary>
        /// �������նΣ�����������
        /// </summary>
        [EnumMember(Value = "Process Cell"), Display(Name = "Process Cell")]
        Process_Cell,

        /// <summary>
        /// ��Ԫ���������������豸/���������������豸
        /// </summary>
        [EnumMember(Value = "Unit"), Display(Name = "Unit")]
        Unit,

        /// <summary>
        /// ���ߣ������ظ�����ɢ����
        /// </summary>
        [EnumMember(Value = "Production Line"), Display(Name = "Production Line")]
        Production_Line,

        /// <summary>
        /// ����/��λ�������ظ�����ɢ�������豸
        /// </summary>
        [EnumMember(Value = "Production Unit"), Display(Name = "Production Unit")]
        Production_Unit,

        /// <summary>
        /// ������Ԫ��������������
        /// </summary>
        [EnumMember(Value = "Work Cell"), Display(Name = "Work Cell")]
        Work_Cell,

        /// <summary>
        /// �洢�������ڴ洢������
        /// </summary>
        [EnumMember(Value = "Storage Zone"), Display(Name = "Storage Zone")]
        Storage_Zone,

        /// <summary>
        /// �洢��Ԫ�����ڴ洢��������豸
        /// </summary>
        [EnumMember(Value = "Storage Unit"), Display(Name = "Storage Unit")]
        Storage_Unit
    }
}