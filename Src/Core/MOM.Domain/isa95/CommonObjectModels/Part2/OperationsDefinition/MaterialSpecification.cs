namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class MaterialSpecification : BaseEntity, IEquatable<MaterialSpecification>
    {
        public MaterialSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialSpecification;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("storageLocation")]
        public string? StorageLocation { get; set; }

        [JsonPropertyName("storageLocationType")]
        public MaterialSpecificationStorageLocationType? StorageLocationType { get; set; }

        [JsonPropertyName("assemblyType")]
        public MaterialSpecificationAssemblyType? AssemblyType { get; set; }

        [JsonPropertyName("assemblyRelationship")]
        public MaterialSpecificationAssemblyRelationship? AssemblyRelationship { get; set; }

        [JsonPropertyName("materialUse")]
        public MaterialSpecificationMaterialUse? MaterialUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        /// <summary>
        /// 组合关系
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialSpecificationIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<MaterialSpecificationIsAssembledFromRelationship>();

        [JsonIgnore]
public virtual List<MaterialSpecificationSpecifiesRelationship> Specifies { get; set; } = new List<MaterialSpecificationSpecifiesRelationship>();

        [JsonIgnore]
public virtual List<MaterialSpecificationHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<MaterialSpecificationHasPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<MaterialSpecificationCorrespondsToClassRelationship> CorrespondsToClass { get; set; } = new List<MaterialSpecificationCorrespondsToClassRelationship>();

        [JsonIgnore]
public virtual List<MaterialSpecificationCorrespondsToDefinitionRelationship> CorrespondsToDefinition { get; set; } = new List<MaterialSpecificationCorrespondsToDefinitionRelationship>();

        [JsonIgnore]
public virtual List<MaterialSpecificationCorrespondsToLotRelationship> CorrespondsToLot { get; set; } = new List<MaterialSpecificationCorrespondsToLotRelationship>();

        [JsonIgnore]
public virtual List<MaterialSpecificationCorrespondsToSublotRelationship> CorrespondsToSublot { get; set; } = new List<MaterialSpecificationCorrespondsToSublotRelationship>();

        [JsonIgnore]
public virtual List<MaterialSpecificationHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<MaterialSpecificationHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<MaterialSpecificationStorageLocationRelRelationship> StorageLocationRel { get; set; } = new List<MaterialSpecificationStorageLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecification);
        }

        public bool Equals(MaterialSpecification? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && StorageLocation == other.StorageLocation && StorageLocationType == other.StorageLocationType && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship && MaterialUse == other.MaterialUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(MaterialSpecification? left, MaterialSpecification? right)
        {
            return EqualityComparer<MaterialSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecification? left, MaterialSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), StorageLocation?.GetHashCode(), StorageLocationType?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode(), MaterialUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}