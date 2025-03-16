namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsTest
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.TestSpecificationCriteria;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class TestSpecificationCriteria : BaseEntity, IEquatable<TestSpecificationCriteria>
    {
        public TestSpecificationCriteria()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:TestSpecificationCriteria;1";

        [JsonPropertyName("sequence")]
        public int? Sequence { get; set; }

        [JsonPropertyName("expression")]
        public string? Expression { get; set; }

        [JsonPropertyName("result")]
        public TestSpecificationCriteriaResult? Result { get; set; }

        [JsonPropertyName("otherResult")]
        public string? OtherResult { get; set; }

        [JsonIgnore]
        public virtual TestSpecificationCriteriaReferencesRelationshipCollection References { get; set; } = new TestSpecificationCriteriaReferencesRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestSpecificationCriteria);
        }

        public bool Equals(TestSpecificationCriteria? other)
        {
            return other is not null && base.Equals(other) && Sequence == other.Sequence && Expression == other.Expression && Result == other.Result && OtherResult == other.OtherResult;
        }

        public static bool operator ==(TestSpecificationCriteria? left, TestSpecificationCriteria? right)
        {
            return EqualityComparer<TestSpecificationCriteria?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestSpecificationCriteria? left, TestSpecificationCriteria? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Sequence?.GetHashCode(), Expression?.GetHashCode(), Result?.GetHashCode(), OtherResult?.GetHashCode());
        }
    }
}