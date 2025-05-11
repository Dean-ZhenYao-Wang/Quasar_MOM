namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActualProperty
{
    public class PhysicalAssetActualPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActualProperty>, IEquatable<PhysicalAssetActualPropertyContainsRelationship>
    {
        public PhysicalAssetActualPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public PhysicalAssetActualPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActualProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActualProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetActualPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetActualPropertyContainsRelationship);
        }

        public bool Equals(PhysicalAssetActualPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetActualPropertyContainsRelationship? left, PhysicalAssetActualPropertyContainsRelationship? right)
        {
            return EqualityComparer<PhysicalAssetActualPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetActualPropertyContainsRelationship? left, PhysicalAssetActualPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetActualPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}