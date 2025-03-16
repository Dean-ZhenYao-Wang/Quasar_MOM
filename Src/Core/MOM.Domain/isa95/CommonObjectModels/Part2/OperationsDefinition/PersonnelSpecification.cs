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
        public virtual PersonnelSpecificationIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new PersonnelSpecificationIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSpecificationSpecifiesRelationshipCollection Specifies { get; set; } = new PersonnelSpecificationSpecifiesRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSpecificationHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new PersonnelSpecificationHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSpecificationCorrespondsToPersonnelClassRelationshipCollection CorrespondsToPersonnelClass { get; set; } = new PersonnelSpecificationCorrespondsToPersonnelClassRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSpecificationCorrespondsToPersonRelationshipCollection CorrespondsToPerson { get; set; } = new PersonnelSpecificationCorrespondsToPersonRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSpecificationHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PersonnelSpecificationHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelSpecificationOperationalLocationRelRelationshipCollection OperationalLocationRel { get; set; } = new PersonnelSpecificationOperationalLocationRelRelationshipCollection();

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