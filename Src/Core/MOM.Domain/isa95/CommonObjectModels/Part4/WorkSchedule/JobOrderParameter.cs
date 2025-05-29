namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.JobOrderParameter;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class JobOrderParameter : BaseEntity, IEquatable<JobOrderParameter>
    {
        public JobOrderParameter()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:JobOrderParameter;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<JobOrderParameterContainsRelationship> Contains { get; set; } = new List<JobOrderParameterContainsRelationship>();

        [JsonIgnore]
public virtual List<JobOrderParameterCorrespondsToSpecificationRelationship> CorrespondsToSpecification { get; set; } = new List<JobOrderParameterCorrespondsToSpecificationRelationship>();

        [JsonIgnore]
public virtual List<JobOrderParameterCorrespondsToProcessRelationship> CorrespondsToProcess { get; set; } = new List<JobOrderParameterCorrespondsToProcessRelationship>();

        [JsonIgnore]
public virtual List<JobOrderParameterHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<JobOrderParameterHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobOrderParameter);
        }

        public bool Equals(JobOrderParameter? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(JobOrderParameter? left, JobOrderParameter? right)
        {
            return EqualityComparer<JobOrderParameter?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobOrderParameter? left, JobOrderParameter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}