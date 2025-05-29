namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsMaterialBillItem;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsMaterialBillItem : BaseEntity, IEquatable<OperationsMaterialBillItem>
    {
        public OperationsMaterialBillItem()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsMaterialBillItem;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("materialClass")]
        public string? MaterialClass { get; set; }

        [JsonPropertyName("materialDefinition")]
        public string? MaterialDefinition { get; set; }

        [JsonPropertyName("useType")]
        public OperationsMaterialBillItemUseType? UseType { get; set; }

        [JsonPropertyName("assemblyType")]
        public OperationsMaterialBillItemAssemblyType? AssemblyType { get; set; }

        [JsonPropertyName("assemblyRelationship")]
        public OperationsMaterialBillItemAssemblyRelationship? AssemblyRelationship { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        /// <summary>
        /// 组合关系
        /// </summary>
        [JsonIgnore]
public virtual List<OperationsMaterialBillItemIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<OperationsMaterialBillItemIsAssembledFromRelationship>();

        [JsonIgnore]
public virtual List<OperationsMaterialBillItemIsUseOfRelationship> IsUseOf { get; set; } = new List<OperationsMaterialBillItemIsUseOfRelationship>();

        [JsonIgnore]
public virtual List<OperationsMaterialBillItemHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<OperationsMaterialBillItemHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsMaterialBillItem);
        }

        public bool Equals(OperationsMaterialBillItem? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && MaterialClass == other.MaterialClass && MaterialDefinition == other.MaterialDefinition && UseType == other.UseType && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(OperationsMaterialBillItem? left, OperationsMaterialBillItem? right)
        {
            return EqualityComparer<OperationsMaterialBillItem?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsMaterialBillItem? left, OperationsMaterialBillItem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), MaterialClass?.GetHashCode(), MaterialDefinition?.GetHashCode(), UseType?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}