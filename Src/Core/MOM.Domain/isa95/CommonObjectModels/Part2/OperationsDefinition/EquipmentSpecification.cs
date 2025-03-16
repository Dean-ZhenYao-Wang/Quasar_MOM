namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.EquipmentSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EquipmentSpecification : BaseEntity, IEquatable<EquipmentSpecification>
    {
        public EquipmentSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentSpecification;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        [JsonPropertyName("operationalLocationType")]
        public EquipmentSpecificationOperationalLocationType? OperationalLocationType { get; set; }

        [JsonPropertyName("equipmentUse")]
        public string? EquipmentUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual EquipmentSpecificationIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new EquipmentSpecificationIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSpecificationSpecifiesRelationshipCollection Specifies { get; set; } = new EquipmentSpecificationSpecifiesRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSpecificationHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new EquipmentSpecificationHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSpecificationCorrespondsToEquipmentClassRelationshipCollection CorrespondsToEquipmentClass { get; set; } = new EquipmentSpecificationCorrespondsToEquipmentClassRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSpecificationCorrespondsToEquipmentRelationshipCollection CorrespondsToEquipment { get; set; } = new EquipmentSpecificationCorrespondsToEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSpecificationHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new EquipmentSpecificationHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentSpecificationOperationalLocationRelRelationshipCollection OperationalLocationRel { get; set; } = new EquipmentSpecificationOperationalLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSpecification);
        }

        public bool Equals(EquipmentSpecification? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType && EquipmentUse == other.EquipmentUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(EquipmentSpecification? left, EquipmentSpecification? right)
        {
            return EqualityComparer<EquipmentSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSpecification? left, EquipmentSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode(), EquipmentUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}