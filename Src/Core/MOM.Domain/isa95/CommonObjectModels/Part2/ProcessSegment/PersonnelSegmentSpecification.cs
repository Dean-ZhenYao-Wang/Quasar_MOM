namespace MOM.Domain.isa95.CommonObjectModels.Part2.ProcessSegment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PersonnelSegmentSpecification : BaseEntity, IEquatable<PersonnelSegmentSpecification>
    {
        public PersonnelSegmentSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonnelSegmentSpecification;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        [JsonPropertyName("operationalLocationType")]
        public PersonnelSegmentSpecificationOperationalLocationType? OperationalLocationType { get; set; }

        [JsonPropertyName("personnelUse")]
        public string? PersonnelUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual PersonnelSegmentSpecificationIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new PersonnelSegmentSpecificationIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSegmentSpecificationSpecifiesRelationshipCollection Specifies { get; set; } = new PersonnelSegmentSpecificationSpecifiesRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSegmentSpecificationHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new PersonnelSegmentSpecificationHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationshipCollection CorrespondsToPersonnelClass { get; set; } = new PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSegmentSpecificationCorrespondsToPersonRelationshipCollection CorrespondsToPerson { get; set; } = new PersonnelSegmentSpecificationCorrespondsToPersonRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSegmentSpecificationHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PersonnelSegmentSpecificationHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSegmentSpecificationOperationalLocationRelRelationshipCollection OperationalLocationRel { get; set; } = new PersonnelSegmentSpecificationOperationalLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSegmentSpecification);
        }

        public bool Equals(PersonnelSegmentSpecification? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType && PersonnelUse == other.PersonnelUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PersonnelSegmentSpecification? left, PersonnelSegmentSpecification? right)
        {
            return EqualityComparer<PersonnelSegmentSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSegmentSpecification? left, PersonnelSegmentSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode(), PersonnelUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}