namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PersonnelActual;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PersonnelActual : BaseEntity, IEquatable<PersonnelActual>
    {
        public PersonnelActual()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonnelActual;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        [JsonPropertyName("operationalLocationType")]
        public PersonnelActualOperationalLocationType? OperationalLocationType { get; set; }

        [JsonPropertyName("personnelUse")]
        public string? PersonnelUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<PersonnelActualIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PersonnelActualIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<PersonnelActualHasValuesOfRelationship> HasValuesOf { get; set; } = new List<PersonnelActualHasValuesOfRelationship>();

        [JsonIgnore]
public virtual List<PersonnelActualCorrespondsToPersonnelClassRelationship> CorrespondsToPersonnelClass { get; set; } = new List<PersonnelActualCorrespondsToPersonnelClassRelationship>();

        [JsonIgnore]
public virtual List<PersonnelActualCorrespondsToPersonRelationship> CorrespondsToPerson { get; set; } = new List<PersonnelActualCorrespondsToPersonRelationship>();

        [JsonIgnore]
public virtual List<PersonnelActualHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<PersonnelActualHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<PersonnelActualOperationalLocationRelRelationship> OperationalLocationRel { get; set; } = new List<PersonnelActualOperationalLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelActual);
        }

        public bool Equals(PersonnelActual? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType && PersonnelUse == other.PersonnelUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PersonnelActual? left, PersonnelActual? right)
        {
            return EqualityComparer<PersonnelActual?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelActual? left, PersonnelActual? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode(), PersonnelUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}