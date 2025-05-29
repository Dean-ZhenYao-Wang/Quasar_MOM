namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsTest
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.TestSpecification;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class TestSpecification : Resource, IEquatable<TestSpecification>
    {
        public TestSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:TestSpecification;1";

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("effectiveStartDate")]
        public DateTime? EffectiveStartDate { get; set; }

        [JsonPropertyName("effectiveEndDate")]
        public DateTime? EffectiveEndDate { get; set; }

        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("testSampleSize")]
        public string? TestSampleSize { get; set; }

        [JsonPropertyName("physicalSample")]
        public TestSpecificationPhysicalSample? PhysicalSample { get; set; }

        [JsonPropertyName("recurrenceQuantity")]
        public string? RecurrenceQuantity { get; set; }

        [JsonPropertyName("recurrenceTimeInterval")]
        public string? RecurrenceTimeInterval { get; set; }

        [JsonIgnore]
public virtual List<TestSpecificationIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<TestSpecificationIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<TestSpecificationSpecifiesTestForOperationsRelationship> SpecifiesTestForOperations { get; set; } = new List<TestSpecificationSpecifiesTestForOperationsRelationship>();

        [JsonIgnore]
public virtual List<TestSpecificationHasValuesOfRelationship> HasValuesOf { get; set; } = new List<TestSpecificationHasValuesOfRelationship>();

        [JsonIgnore]
public virtual List<TestSpecificationIsMadeUpOfCriteriaRelationship> IsMadeUpOfCriteria { get; set; } = new List<TestSpecificationIsMadeUpOfCriteriaRelationship>();

        [JsonIgnore]
public virtual List<TestSpecificationEvaluatesRelationship> Evaluates { get; set; } = new List<TestSpecificationEvaluatesRelationship>();

        [JsonIgnore]
public virtual List<TestSpecificationSpecifiesTestForObjectRelationship> SpecifiesTestForObject { get; set; } = new List<TestSpecificationSpecifiesTestForObjectRelationship>();

        [JsonIgnore]
public virtual List<TestSpecificationHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<TestSpecificationHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestSpecification);
        }

        public bool Equals(TestSpecification? other)
        {
            return other is not null && base.Equals(other) && Version == other.Version && EffectiveStartDate == other.EffectiveStartDate && EffectiveEndDate == other.EffectiveEndDate && PublishedDate == other.PublishedDate && HierarchyScope == other.HierarchyScope && TestSampleSize == other.TestSampleSize && PhysicalSample == other.PhysicalSample && RecurrenceQuantity == other.RecurrenceQuantity && RecurrenceTimeInterval == other.RecurrenceTimeInterval;
        }

        public static bool operator ==(TestSpecification? left, TestSpecification? right)
        {
            return EqualityComparer<TestSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestSpecification? left, TestSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Version?.GetHashCode(), EffectiveStartDate?.GetHashCode(), EffectiveEndDate?.GetHashCode(), PublishedDate?.GetHashCode(), HierarchyScope?.GetHashCode(), TestSampleSize?.GetHashCode(), PhysicalSample?.GetHashCode(), RecurrenceQuantity?.GetHashCode(), RecurrenceTimeInterval?.GetHashCode());
        }
    }
}