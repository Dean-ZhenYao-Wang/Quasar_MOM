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
        public virtual PersonnelActualIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new PersonnelActualIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelActualHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new PersonnelActualHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelActualCorrespondsToPersonnelClassRelationshipCollection CorrespondsToPersonnelClass { get; set; } = new PersonnelActualCorrespondsToPersonnelClassRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelActualCorrespondsToPersonRelationshipCollection CorrespondsToPerson { get; set; } = new PersonnelActualCorrespondsToPersonRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelActualHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PersonnelActualHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelActualOperationalLocationRelRelationshipCollection OperationalLocationRel { get; set; } = new PersonnelActualOperationalLocationRelRelationshipCollection();

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