namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirementProperty
{
    public class PhysicalAssetRequirementPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirementProperty>, IEquatable<PhysicalAssetRequirementPropertyContainsRelationship>
    {
        public PhysicalAssetRequirementPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public PhysicalAssetRequirementPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirementProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetRequirementPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetRequirementPropertyContainsRelationship);
        }

        public bool Equals(PhysicalAssetRequirementPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetRequirementPropertyContainsRelationship? left, PhysicalAssetRequirementPropertyContainsRelationship? right)
        {
            return EqualityComparer<PhysicalAssetRequirementPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetRequirementPropertyContainsRelationship? left, PhysicalAssetRequirementPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetRequirementPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}