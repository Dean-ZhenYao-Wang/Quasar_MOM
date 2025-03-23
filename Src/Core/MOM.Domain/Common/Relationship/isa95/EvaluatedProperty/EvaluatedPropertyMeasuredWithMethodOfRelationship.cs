namespace MOM.Domain.Common.Relationship.isa95.EvaluatedProperty
{
    public class EvaluatedPropertyMeasuredWithMethodOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition>, IEquatable<EvaluatedPropertyMeasuredWithMethodOfRelationship>
    {
        public EvaluatedPropertyMeasuredWithMethodOfRelationship()
        {
            Name = "measuredWithMethodOf";
        }

        public EvaluatedPropertyMeasuredWithMethodOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.EvaluatedProperty source, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EvaluatedPropertyMeasuredWithMethodOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EvaluatedPropertyMeasuredWithMethodOfRelationship);
        }

        public bool Equals(EvaluatedPropertyMeasuredWithMethodOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EvaluatedPropertyMeasuredWithMethodOfRelationship? left, EvaluatedPropertyMeasuredWithMethodOfRelationship? right)
        {
            return EqualityComparer<EvaluatedPropertyMeasuredWithMethodOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EvaluatedPropertyMeasuredWithMethodOfRelationship? left, EvaluatedPropertyMeasuredWithMethodOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EvaluatedPropertyMeasuredWithMethodOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}