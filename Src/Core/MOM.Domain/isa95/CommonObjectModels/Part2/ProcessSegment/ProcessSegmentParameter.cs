namespace MOM.Domain.isa95.CommonObjectModels.Part2.ProcessSegment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.ProcessSegmentParameter;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ProcessSegmentParameter : ResourceProperty, IEquatable<ProcessSegmentParameter>
    {
        public ProcessSegmentParameter()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ProcessSegmentParameter;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
public virtual List<ProcessSegmentParameterContainsRelationship> Contains { get; set; } = new List<ProcessSegmentParameterContainsRelationship>();

        [JsonIgnore]
public virtual List<ProcessSegmentParameterHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<ProcessSegmentParameterHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentParameter);
        }

        public bool Equals(ProcessSegmentParameter? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(ProcessSegmentParameter? left, ProcessSegmentParameter? right)
        {
            return EqualityComparer<ProcessSegmentParameter?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentParameter? left, ProcessSegmentParameter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}