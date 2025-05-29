namespace MOM.Domain.Common.Relationship.isa95.EvaluatedProperty
{
    public class EvaluatedPropertyCorrespondsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.EvaluatedProperty ,Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty>, IEquatable<EvaluatedPropertyCorrespondsToRelationship>
    {
        public EvaluatedPropertyCorrespondsToRelationship()
        {
            Name = "correspondsTo";
        }

        public EvaluatedPropertyCorrespondsToRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.EvaluatedProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EvaluatedPropertyCorrespondsToRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EvaluatedPropertyCorrespondsToRelationship);
        }

        public bool Equals(EvaluatedPropertyCorrespondsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EvaluatedPropertyCorrespondsToRelationship? left, EvaluatedPropertyCorrespondsToRelationship? right)
        {
            return EqualityComparer<EvaluatedPropertyCorrespondsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EvaluatedPropertyCorrespondsToRelationship? left, EvaluatedPropertyCorrespondsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EvaluatedPropertyCorrespondsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}