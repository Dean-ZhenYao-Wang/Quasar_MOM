namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.ParameterSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ParameterSpecification : ResourceProperty, IEquatable<ParameterSpecification>
    {
        public ParameterSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ParameterSpecification;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
public virtual List<ParameterSpecificationContainsRelationship> Contains { get; set; } = new List<ParameterSpecificationContainsRelationship>();

        [JsonIgnore]
public virtual List<ParameterSpecificationHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<ParameterSpecificationHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ParameterSpecification);
        }

        public bool Equals(ParameterSpecification? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(ParameterSpecification? left, ParameterSpecification? right)
        {
            return EqualityComparer<ParameterSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(ParameterSpecification? left, ParameterSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}