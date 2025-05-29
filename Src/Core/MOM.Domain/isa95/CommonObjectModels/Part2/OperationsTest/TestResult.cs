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
public virtual List<TestResultIsMadeUpOfResultsRelationship> IsMadeUpOfResults { get; set; } = new List<TestResultIsMadeUpOfResultsRelationship>();

        [JsonIgnore]
public virtual List<TestResultIsMadeUpOfMeasurementsRelationship> IsMadeUpOfMeasurements { get; set; } = new List<TestResultIsMadeUpOfMeasurementsRelationship>();

        [JsonIgnore]
public virtual List<TestResultGeneratedInContextOfRelationship> GeneratedInContextOf { get; set; } = new List<TestResultGeneratedInContextOfRelationship>();

        [JsonIgnore]
public virtual List<TestResultRecordsTestResultsForRelationship> RecordsTestResultsFor { get; set; } = new List<TestResultRecordsTestResultsForRelationship>();

        [JsonIgnore]
public virtual List<TestResultHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<TestResultHierarchyScopeRelRelationship>();

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