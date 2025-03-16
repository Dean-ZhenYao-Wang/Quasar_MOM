namespace MOM.Domain.isa95.CommonObjectModels.Part2.ProcessSegment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class MaterialSegmentSpecification : BaseEntity, IEquatable<MaterialSegmentSpecification>
    {
        public MaterialSegmentSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialSegmentSpecification;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("storageLocation")]
        public string? StorageLocation { get; set; }

        [JsonPropertyName("storageLocationType")]
        public MaterialSegmentSpecificationStorageLocationType? StorageLocationType { get; set; }

        [JsonPropertyName("assemblyType")]
        public MaterialSegmentSpecificationAssemblyType? AssemblyType { get; set; }

        [JsonPropertyName("assemblyRelationship")]
        public MaterialSegmentSpecificationAssemblyRelationship? AssemblyRelationship { get; set; }

        [JsonPropertyName("materialUse")]
        public MaterialSegmentSpecificationMaterialUse? MaterialUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        /// <summary>
        /// 组合关系
        /// </summary>
        [JsonIgnore]
        public virtual MaterialSegmentSpecificationIsAssembledFromRelationshipCollection IsAssembledFrom { get; set; } = new MaterialSegmentSpecificationIsAssembledFromRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationSpecifiesRelationshipCollection Specifies { get; set; } = new MaterialSegmentSpecificationSpecifiesRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new MaterialSegmentSpecificationHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationCorrespondsToClassRelationshipCollection CorrespondsToClass { get; set; } = new MaterialSegmentSpecificationCorrespondsToClassRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationCorrespondsToDefinitionRelationshipCollection CorrespondsToDefinition { get; set; } = new MaterialSegmentSpecificationCorrespondsToDefinitionRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationCorrespondsToLotRelationshipCollection CorrespondsToLot { get; set; } = new MaterialSegmentSpecificationCorrespondsToLotRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationCorrespondsToSublotRelationshipCollection CorrespondsToSublot { get; set; } = new MaterialSegmentSpecificationCorrespondsToSublotRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new MaterialSegmentSpecificationHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialSegmentSpecificationStorageLocationRelRelationshipCollection StorageLocationRel { get; set; } = new MaterialSegmentSpecificationStorageLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecification);
        }

        public bool Equals(MaterialSegmentSpecification? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && StorageLocation == other.StorageLocation && StorageLocationType == other.StorageLocationType && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship && MaterialUse == other.MaterialUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(MaterialSegmentSpecification? left, MaterialSegmentSpecification? right)
        {
            return EqualityComparer<MaterialSegmentSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecification? left, MaterialSegmentSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), StorageLocation?.GetHashCode(), StorageLocationType?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode(), MaterialUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}