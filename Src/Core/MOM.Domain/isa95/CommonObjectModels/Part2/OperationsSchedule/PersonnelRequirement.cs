namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PersonnelRequirement;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PersonnelRequirement : BaseEntity, IEquatable<PersonnelRequirement>
    {
        public PersonnelRequirement()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonnelRequirement;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        [JsonPropertyName("operationalLocationType")]
        public PersonnelRequirementOperationalLocationType? OperationalLocationType { get; set; }

        [JsonPropertyName("personnelUse")]
        public string? PersonnelUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual PersonnelRequirementIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new PersonnelRequirementIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelRequirementHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new PersonnelRequirementHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelRequirementCorrespondsToPersonnelClassRelationshipCollection CorrespondsToPersonnelClass { get; set; } = new PersonnelRequirementCorrespondsToPersonnelClassRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelRequirementCorrespondsToPersonRelationshipCollection CorrespondsToPerson { get; set; } = new PersonnelRequirementCorrespondsToPersonRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelRequirementHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PersonnelRequirementHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelRequirementOperationalLocationRelRelationshipCollection OperationalLocationRel { get; set; } = new PersonnelRequirementOperationalLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelRequirement);
        }

        public bool Equals(PersonnelRequirement? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType && PersonnelUse == other.PersonnelUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PersonnelRequirement? left, PersonnelRequirement? right)
        {
            return EqualityComparer<PersonnelRequirement?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelRequirement? left, PersonnelRequirement? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode(), PersonnelUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}