namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PersonnelSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PersonnelSpecification : BaseEntity, IEquatable<PersonnelSpecification>
    {
        public PersonnelSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonnelSpecification;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        [JsonPropertyName("operationalLocationType")]
        public PersonnelSpecificationOperationalLocationType? OperationalLocationType { get; set; }

        [JsonPropertyName("personnelUse")]
        public string? PersonnelUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<PersonnelSpecificationIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PersonnelSpecificationIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSpecificationSpecifiesRelationship> Specifies { get; set; } = new List<PersonnelSpecificationSpecifiesRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSpecificationHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<PersonnelSpecificationHasPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSpecificationCorrespondsToPersonnelClassRelationship> CorrespondsToPersonnelClass { get; set; } = new List<PersonnelSpecificationCorrespondsToPersonnelClassRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSpecificationCorrespondsToPersonRelationship> CorrespondsToPerson { get; set; } = new List<PersonnelSpecificationCorrespondsToPersonRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSpecificationHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<PersonnelSpecificationHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<PersonnelSpecificationOperationalLocationRelRelationship> OperationalLocationRel { get; set; } = new List<PersonnelSpecificationOperationalLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecification);
        }

        public bool Equals(PersonnelSpecification? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType && PersonnelUse == other.PersonnelUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PersonnelSpecification? left, PersonnelSpecification? right)
        {
            return EqualityComparer<PersonnelSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecification? left, PersonnelSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode(), PersonnelUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}