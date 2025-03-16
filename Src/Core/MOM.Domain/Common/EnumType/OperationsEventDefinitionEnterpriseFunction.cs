namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationsEventDefinitionEnterpriseFunction
    {
        [EnumMember(Value = "orderProcessing"), Display(Name = "Order processing")]
        orderProcessing,

        [EnumMember(Value = "operationsScheduling"), Display(Name = "Operations scheduling")]
        operationsScheduling,

        [EnumMember(Value = "productionControl"), Display(Name = "Production control")]
        productionControl,

        [EnumMember(Value = "materialAndEnergyControl"), Display(Name = "Material and energy control")]
        materialAndEnergyControl,

        [EnumMember(Value = "procurement"), Display(Name = "Procurement")]
        procurement,

        [EnumMember(Value = "qualityAssurance"), Display(Name = "Quality assurance")]
        qualityAssurance,

        [EnumMember(Value = "productInventoryControl"), Display(Name = "Product inventory control")]
        productInventoryControl,

        [EnumMember(Value = "productCostAccounting"), Display(Name = "Product cost accounting")]
        productCostAccounting,

        [EnumMember(Value = "productShippingAdministration"), Display(Name = "Product shipping administration")]
        productShippingAdministration,

        [EnumMember(Value = "maintenanceManagement"), Display(Name = "Maintenance management")]
        maintenanceManagement,

        [EnumMember(Value = "marketingAndSales"), Display(Name = "Marketing and sales")]
        marketingAndSales,

        [EnumMember(Value = "rAndD"), Display(Name = "R&D")]
        rAndD,

        [EnumMember(Value = "engineering"), Display(Name = "Engineering")]
        engineering
    }
}