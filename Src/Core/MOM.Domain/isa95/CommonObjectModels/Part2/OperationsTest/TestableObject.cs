namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsTest
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.TestableObject;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// ��Ҫ��������Ҫ�����ԵĶ���������һ������ָ��TestableObject��ԭISA��(n)...(0.n)��ϵ�Ĳ��Թ淶��TestableObject������ת
    /// </summary>
    public class TestableObject : BaseEntity, IEquatable<TestableObject>, IEquatable<BaseEntity>
    {
        public TestableObject()
        {
        }

        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:isa95:TestableObject;1";

        [JsonIgnore]
        public virtual TestableObjectSpecifiesRelationshipCollection Specifies { get; set; } = new TestableObjectSpecifiesRelationshipCollection();

        [JsonIgnore]
        public virtual TestableObjectHasTestableObjectPropertyValuesOfRelationshipCollection HasTestableObjectPropertyValuesOf { get; set; } = new TestableObjectHasTestableObjectPropertyValuesOfRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestableObject);
        }

        public bool Equals(TestableObject? other)
        {
            return other is not null && DtId == other.DtId;
        }

        public static bool operator ==(TestableObject? left, TestableObject? right)
        {
            return EqualityComparer<TestableObject?>.Default.Equals(left, right);
        }

        public static bool operator !=(TestableObject? left, TestableObject? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), ModelId?.GetHashCode());
        }

        public bool Equals(BaseEntity? other)
        {
            return Equals(other as TestableObject) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}