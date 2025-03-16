namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EquipmentRequirementEquipmentLevel
    {
        [EnumMember(Value = "Enterprise"), Display(Name = " ")]
        Enterprise,

        [EnumMember(Value = "Site"), Display(Name = " ")]
        Site,

        [EnumMember(Value = "Area"), Display(Name = " ")]
        Area,

        [EnumMember(Value = "Work Center"), Display(Name = "Work Center")]
        Work_Center,

        [EnumMember(Value = "Work Unit"), Display(Name = "Work Unit")]
        Work_Unit,

        [EnumMember(Value = "Process Cell"), Display(Name = "Process Cell")]
        Process_Cell,

        [EnumMember(Value = "Unit"), Display(Name = " ")]
        Unit,

        [EnumMember(Value = "Production Line"), Display(Name = "Production Line")]
        Production_Line,

        [EnumMember(Value = "Production Unit"), Display(Name = "Production Unit")]
        Production_Unit,

        [EnumMember(Value = "Work Cell"), Display(Name = "Work Cell")]
        Work_Cell,

        [EnumMember(Value = "Storage Zone"), Display(Name = "Storage Zone")]
        Storage_Zone,

        [EnumMember(Value = "Storage Unit"), Display(Name = "Storage Unit")]
        Storage_Unit
    }
}