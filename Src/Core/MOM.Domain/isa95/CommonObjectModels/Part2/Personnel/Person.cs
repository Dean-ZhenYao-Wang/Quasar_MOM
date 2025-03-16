namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.Person;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public partial class Person : Resource, IEquatable<Person>
    {
        public Person()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:Person;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        [JsonPropertyName("operationalLocationType")]
        public PersonOperationalLocationType? OperationalLocationType { get; set; }

        [JsonIgnore]
        public virtual PersonDefinedByRelationshipCollection DefinedBy { get; set; } = new PersonDefinedByRelationshipCollection();

        [JsonIgnore]
        public virtual PersonHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new PersonHasValuesOfRelationshipCollection();

        [MaxLength(1)]
        [JsonIgnore]
        public virtual PersonHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PersonHierarchyScopeRelRelationshipCollection();

        [MaxLength(1)]
        [JsonIgnore]
        public virtual PersonOperationalLocationRelRelationshipCollection OperationalLocationRel { get; set; } = new PersonOperationalLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && Name == other.Name && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType;
        }

        public static bool operator ==(Person? left, Person? right)
        {
            return EqualityComparer<Person?>.Default.Equals(left, right);
        }

        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), Name?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode());
        }
    }
}