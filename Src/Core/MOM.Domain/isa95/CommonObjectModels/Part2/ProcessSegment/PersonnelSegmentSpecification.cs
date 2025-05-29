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
public virtual List<PersonnelSegmentSpecificationIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PersonnelSegmentSpecificationIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSegmentSpecificationSpecifiesRelationship> Specifies { get; set; } = new List<PersonnelSegmentSpecificationSpecifiesRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSegmentSpecificationHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<PersonnelSegmentSpecificationHasPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship> CorrespondsToPersonnelClass { get; set; } = new List<PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSegmentSpecificationCorrespondsToPersonRelationship> CorrespondsToPerson { get; set; } = new List<PersonnelSegmentSpecificationCorrespondsToPersonRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSegmentSpecificationHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<PersonnelSegmentSpecificationHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSegmentSpecificationOperationalLocationRelRelationship> OperationalLocationRel { get; set; } = new List<PersonnelSegmentSpecificationOperationalLocationRelRelationship>();

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