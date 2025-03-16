namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.SegmentParameter;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SegmentParameter : BaseEntity, IEquatable<SegmentParameter>
    {
        public SegmentParameter()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:SegmentParameter;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual SegmentParameterContainsRelationshipCollection Contains { get; set; } = new SegmentParameterContainsRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentParameterCorrespondsToSpecificationRelationshipCollection CorrespondsToSpecification { get; set; } = new SegmentParameterCorrespondsToSpecificationRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentParameterCorrespondsToProcessRelationshipCollection CorrespondsToProcess { get; set; } = new SegmentParameterCorrespondsToProcessRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentParameterHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new SegmentParameterHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentParameter);
        }

        public bool Equals(SegmentParameter? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(SegmentParameter? left, SegmentParameter? right)
        {
            return EqualityComparer<SegmentParameter?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentParameter? left, SegmentParameter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}