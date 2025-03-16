namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FromResourceReferenceResourceType
    {
        [EnumMember(Value = "personnel class"), Display(Name = " ")]
        personnel_class,

        [EnumMember(Value = "person"), Display(Name = " ")]
        person,

        [EnumMember(Value = "equipment class"), Display(Name = " ")]
        equipment_class,

        [EnumMember(Value = "equipment"), Display(Name = " ")]
        equipment,

        [EnumMember(Value = "physical asset class"), Display(Name = " ")]
        physical_asset_class,

        [EnumMember(Value = "physical asset"), Display(Name = " ")]
        physical_asset,

        [EnumMember(Value = "material class"), Display(Name = " ")]
        material_class,

        [EnumMember(Value = "material definition"), Display(Name = " ")]
        material_definition,

        [EnumMember(Value = "material lot"), Display(Name = " ")]
        material_lot,

        [EnumMember(Value = "material sublot"), Display(Name = " ")]
        material_sublot,

        [EnumMember(Value = "work master"), Display(Name = " ")]
        work_master,

        [EnumMember(Value = "process segment"), Display(Name = " ")]
        process_segment,

        [EnumMember(Value = "operation definition"), Display(Name = " ")]
        operation_definition,

        [EnumMember(Value = "operational location"), Display(Name = " ")]
        operational_location,

        [EnumMember(Value = "operations segment"), Display(Name = " ")]
        operations_segment,

        [EnumMember(Value = "test specification"), Display(Name = " ")]
        test_specification,

        [EnumMember(Value = "test result"), Display(Name = " ")]
        test_result
    }
}