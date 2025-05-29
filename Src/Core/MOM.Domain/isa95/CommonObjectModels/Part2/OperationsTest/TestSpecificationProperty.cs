namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsTest
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.TestSpecificationProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class TestSpecificationProperty : ResourceProperty, IEquatable<TestSpecificationProperty>
    {
        public TestSpecificationProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:TestSpecificationProperty;1";

        [JsonIgnore]
public virtual List<TestSpecificationPropertyContainsRelationship> Contains { get; set; } = new List<TestSpecificationPropertyContainsRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestSpecificationProperty);
        }

        public bool Equals(TestSpecificationProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(TestSpecificationProperty? left, TestSpecificationProperty? right)
        {
            return EqualityComparer<TestSpecificationProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestSpecificationProperty? left, TestSpecificationProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}