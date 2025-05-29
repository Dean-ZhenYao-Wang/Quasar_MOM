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
public virtual List<PersonnelRequirementIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PersonnelRequirementIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<PersonnelRequirementHasValuesOfRelationship> HasValuesOf { get; set; } = new List<PersonnelRequirementHasValuesOfRelationship>();

        [JsonIgnore]
public virtual List<PersonnelRequirementCorrespondsToPersonnelClassRelationship> CorrespondsToPersonnelClass { get; set; } = new List<PersonnelRequirementCorrespondsToPersonnelClassRelationship>();

        [JsonIgnore]
public virtual List<PersonnelRequirementCorrespondsToPersonRelationship> CorrespondsToPerson { get; set; } = new List<PersonnelRequirementCorrespondsToPersonRelationship>();

        [JsonIgnore]
public virtual List<PersonnelRequirementHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<PersonnelRequirementHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<PersonnelRequirementOperationalLocationRelRelationship> OperationalLocationRel { get; set; } = new List<PersonnelRequirementOperationalLocationRelRelationship>();

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