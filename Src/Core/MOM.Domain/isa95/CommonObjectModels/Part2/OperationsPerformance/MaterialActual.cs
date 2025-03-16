namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialActual;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialActual : BaseEntity, IEquatable<MaterialActual>
    {
        public MaterialActual()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialActual;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("storageLocation")]
        public string? StorageLocation { get; set; }

        [JsonPropertyName("storageLocationType")]
        public MaterialActualStorageLocationType? StorageLocationType { get; set; }

        [JsonPropertyName("materialUse")]
        public MaterialActualMaterialUse? MaterialUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonPropertyName("assemblyType")]
        public MaterialActualAssemblyType? AssemblyType { get; set; }

        [JsonPropertyName("assemblyRelationship")]
        public MaterialActualAssemblyRelationship? AssemblyRelationship { get; set; }

        /// <summary>
        /// 组合关系
        /// </summary>
        [JsonIgnore]
        public virtual MaterialActualIsAssembledFromRelationshipCollection IsAssembledFrom { get; set; } = new MaterialActualIsAssembledFromRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialActualHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new MaterialActualHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialActualCorrespondsToClassRelationshipCollection CorrespondsToClass { get; set; } = new MaterialActualCorrespondsToClassRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialActualCorrespondsToDefinitionRelationshipCollection CorrespondsToDefinition { get; set; } = new MaterialActualCorrespondsToDefinitionRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialActualCorrespondsToLotRelationshipCollection CorrespondsToLot { get; set; } = new MaterialActualCorrespondsToLotRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialActualCorrespondsToSublotRelationshipCollection CorrespondsToSublot { get; set; } = new MaterialActualCorrespondsToSublotRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialActualHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new MaterialActualHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialActualStorageLocationRelRelationshipCollection StorageLocationRel { get; set; } = new MaterialActualStorageLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActual);
        }

        public bool Equals(MaterialActual? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && StorageLocation == other.StorageLocation && StorageLocationType == other.StorageLocationType && MaterialUse == other.MaterialUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship;
        }

        public static bool operator ==(MaterialActual? left, MaterialActual? right)
        {
            return EqualityComparer<MaterialActual?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActual? left, MaterialActual? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), StorageLocation?.GetHashCode(), StorageLocationType?.GetHashCode(), MaterialUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode());
        }
    }
}