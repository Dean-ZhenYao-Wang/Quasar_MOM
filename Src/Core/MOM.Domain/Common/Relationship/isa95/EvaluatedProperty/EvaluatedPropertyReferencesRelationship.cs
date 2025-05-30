namespace MOM.Domain.Common.Relationship.isa95.EvaluatedProperty
{
    public class EvaluatedPropertyReferencesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.EvaluatedProperty ,Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationCriteria>, IEquatable<EvaluatedPropertyReferencesRelationship>
    {
        public EvaluatedPropertyReferencesRelationship()
        {
            Name = "references";
        }

        public EvaluatedPropertyReferencesRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.EvaluatedProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationCriteria target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EvaluatedPropertyReferencesRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EvaluatedPropertyReferencesRelationship);
        }

        public bool Equals(EvaluatedPropertyReferencesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EvaluatedPropertyReferencesRelationship? left, EvaluatedPropertyReferencesRelationship? right)
        {
            return EqualityComparer<EvaluatedPropertyReferencesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EvaluatedPropertyReferencesRelationship? left, EvaluatedPropertyReferencesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EvaluatedPropertyReferencesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}