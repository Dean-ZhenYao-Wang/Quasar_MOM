namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialRequirement;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class MaterialRequirement : BaseEntity, IEquatable<MaterialRequirement>
    {
        public MaterialRequirement()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialRequirement;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("storageLocation")]
        public string? StorageLocation { get; set; }

        [JsonPropertyName("storageLocationType")]
        public MaterialRequirementStorageLocationType? StorageLocationType { get; set; }

        [JsonPropertyName("materialUse")]
        public MaterialRequirementMaterialUse? MaterialUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonPropertyName("assemblyType")]
        public MaterialRequirementAssemblyType? AssemblyType { get; set; }

        [JsonPropertyName("assemblyRelationship")]
        public virtual MaterialRequirementAssemblyRelationship? AssemblyRelationship { get; set; }

        /// <summary>
        /// 组合关系
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialRequirementIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<MaterialRequirementIsAssembledFromRelationship>();

        [JsonIgnore]
public virtual List<MaterialRequirementHasValuesOfRelationship> HasValuesOf { get; set; } = new List<MaterialRequirementHasValuesOfRelationship>();

        [JsonIgnore]
public virtual List<MaterialRequirementContainsRelationship> Contains { get; set; } = new List<MaterialRequirementContainsRelationship>();

        [JsonIgnore]
public virtual List<MaterialRequirementCorrespondsToClassRelationship> CorrespondsToClass { get; set; } = new List<MaterialRequirementCorrespondsToClassRelationship>();

        [JsonIgnore]
public virtual List<MaterialRequirementCorrespondsToDefinitionRelationship> CorrespondsToDefinition { get; set; } = new List<MaterialRequirementCorrespondsToDefinitionRelationship>();

        [JsonIgnore]
public virtual List<MaterialRequirementCorrespondsToLotRelationship> CorrespondsToLot { get; set; } = new List<MaterialRequirementCorrespondsToLotRelationship>();

        [JsonIgnore]
public virtual List<MaterialRequirementCorrespondsToSublotRelationship> CorrespondsToSublot { get; set; } = new List<MaterialRequirementCorrespondsToSublotRelationship>();

        [JsonIgnore]
public virtual List<MaterialRequirementHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<MaterialRequirementHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<MaterialRequirementStorageLocationRelRelationship> StorageLocationRel { get; set; } = new List<MaterialRequirementStorageLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirement);
        }

        public bool Equals(MaterialRequirement? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && StorageLocation == other.StorageLocation && StorageLocationType == other.StorageLocationType && MaterialUse == other.MaterialUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship;
        }

        public static bool operator ==(MaterialRequirement? left, MaterialRequirement? right)
        {
            return EqualityComparer<MaterialRequirement?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirement? left, MaterialRequirement? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), StorageLocation?.GetHashCode(), StorageLocationType?.GetHashCode(), MaterialUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode());
        }
    }
}