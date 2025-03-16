namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsTest
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class TestableObjectProperty : BaseEntity, IEquatable<TestableObjectProperty>, IEquatable<BaseEntity>
    {
        public TestableObjectProperty()
        {
        }

        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:isa95:TestableObjectProperty;1";

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestableObjectProperty);
        }

        public bool Equals(TestableObjectProperty? other)
        {
            return other is not null && DtId == other.DtId;
        }

        public static bool operator ==(TestableObjectProperty? left, TestableObjectProperty? right)
        {
            return EqualityComparer<TestableObjectProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestableObjectProperty? left, TestableObjectProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), ModelId?.GetHashCode());
        }

        public bool Equals(BaseEntity? other)
        {
            return Equals(other as TestableObjectProperty) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}