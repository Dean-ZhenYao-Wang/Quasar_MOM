namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsTest
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.TestResult;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class TestResult : Resource, IEquatable<TestResult>
    {
        public TestResult()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:TestResult;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("evaluationDate")]
        public DateTime? EvaluationDate { get; set; }

        [JsonPropertyName("evaluatedCriterionResult")]
        public TestResultEvaluatedCriterionResult? EvaluatedCriterionResult { get; set; }

        [JsonPropertyName("otherEvaluatedCriterionResult")]
        public string? OtherEvaluatedCriterionResult { get; set; }

        [JsonPropertyName("expiration")]
        public DateTime? Expiration { get; set; }

        [JsonIgnore]
        public virtual TestResultIsMadeUpOfResultsRelationshipCollection IsMadeUpOfResults { get; set; } = new TestResultIsMadeUpOfResultsRelationshipCollection();

        [JsonIgnore]
        public virtual TestResultIsMadeUpOfMeasurementsRelationshipCollection IsMadeUpOfMeasurements { get; set; } = new TestResultIsMadeUpOfMeasurementsRelationshipCollection();

        [JsonIgnore]
        public virtual TestResultGeneratedInContextOfRelationshipCollection GeneratedInContextOf { get; set; } = new TestResultGeneratedInContextOfRelationshipCollection();

        [JsonIgnore]
        public virtual TestResultRecordsTestResultsForRelationshipCollection RecordsTestResultsFor { get; set; } = new TestResultRecordsTestResultsForRelationshipCollection();

        [JsonIgnore]
        public virtual TestResultHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new TestResultHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestResult);
        }

        public bool Equals(TestResult? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && EvaluationDate == other.EvaluationDate && EvaluatedCriterionResult == other.EvaluatedCriterionResult && OtherEvaluatedCriterionResult == other.OtherEvaluatedCriterionResult && Expiration == other.Expiration;
        }

        public static bool operator ==(TestResult? left, TestResult? right)
        {
            return EqualityComparer<TestResult?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestResult? left, TestResult? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), EvaluationDate?.GetHashCode(), EvaluatedCriterionResult?.GetHashCode(), OtherEvaluatedCriterionResult?.GetHashCode(), Expiration?.GetHashCode());
        }
    }
}