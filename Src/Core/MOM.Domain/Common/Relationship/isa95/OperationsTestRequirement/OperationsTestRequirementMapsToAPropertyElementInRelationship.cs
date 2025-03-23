namespace MOM.Domain.Common.Relationship.isa95.OperationsTestRequirement
{
    public class OperationsTestRequirementMapsToAPropertyElementInRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty>, IEquatable<OperationsTestRequirementMapsToAPropertyElementInRelationship>
    {
        public OperationsTestRequirementMapsToAPropertyElementInRelationship()
        {
            Name = "mapsToAPropertyElementIn";
        }

        public OperationsTestRequirementMapsToAPropertyElementInRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.OperationsTestRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsTestRequirementMapsToAPropertyElementInRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsTestRequirementMapsToAPropertyElementInRelationship);
        }

        public bool Equals(OperationsTestRequirementMapsToAPropertyElementInRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsTestRequirementMapsToAPropertyElementInRelationship? left, OperationsTestRequirementMapsToAPropertyElementInRelationship? right)
        {
            return EqualityComparer<OperationsTestRequirementMapsToAPropertyElementInRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsTestRequirementMapsToAPropertyElementInRelationship? left, OperationsTestRequirementMapsToAPropertyElementInRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsTestRequirementMapsToAPropertyElementInRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}