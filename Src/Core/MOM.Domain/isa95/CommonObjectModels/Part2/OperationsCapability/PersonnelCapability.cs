namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PersonnelCapability;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PersonnelCapability : BaseEntity, IEquatable<PersonnelCapability>
    {
        public PersonnelCapability()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonnelCapability;1";

        [JsonPropertyName("capabilityType")]
        public PersonnelCapabilityCapabilityType? CapabilityType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("confidenceFactor")]
        public string? ConfidenceFactor { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        [JsonPropertyName("operationalLocationType")]
        public PersonnelCapabilityOperationalLocationType? OperationalLocationType { get; set; }

        [JsonPropertyName("personnelUse")]
        public string? PersonnelUse { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<PersonnelCapabilityIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PersonnelCapabilityIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<PersonnelCapabilityHasValuesOfRelationship> HasValuesOf { get; set; } = new List<PersonnelCapabilityHasValuesOfRelationship>();

        [JsonIgnore]
public virtual List<PersonnelCapabilityCorrespondsToPersonnelClassRelationship> CorrespondsToPersonnelClass { get; set; } = new List<PersonnelCapabilityCorrespondsToPersonnelClassRelationship>();

        [JsonIgnore]
public virtual List<PersonnelCapabilityCorrespondsToPersonRelationship> CorrespondsToPerson { get; set; } = new List<PersonnelCapabilityCorrespondsToPersonRelationship>();

        [JsonIgnore]
public virtual List<PersonnelCapabilityHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<PersonnelCapabilityHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<PersonnelCapabilityOperationalLocationRelRelationship> OperationalLocationRel { get; set; } = new List<PersonnelCapabilityOperationalLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelCapability);
        }

        public bool Equals(PersonnelCapability? other)
        {
            return other is not null && base.Equals(other) && CapabilityType == other.CapabilityType && Reason == other.Reason && ConfidenceFactor == other.ConfidenceFactor && HierarchyScope == other.HierarchyScope && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType && PersonnelUse == other.PersonnelUse && StartTime == other.StartTime && EndTime == other.EndTime && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PersonnelCapability? left, PersonnelCapability? right)
        {
            return EqualityComparer<PersonnelCapability?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelCapability? left, PersonnelCapability? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), CapabilityType?.GetHashCode(), Reason?.GetHashCode(), ConfidenceFactor?.GetHashCode(), HierarchyScope?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode(), PersonnelUse?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}