namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirementProperty>, IEquatable<PhysicalAssetRequirementHasValuesOfRelationship>
    {
        public PhysicalAssetRequirementHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public PhysicalAssetRequirementHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirementProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetRequirementHasValuesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetRequirementHasValuesOfRelationship);
        }

        public bool Equals(PhysicalAssetRequirementHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetRequirementHasValuesOfRelationship? left, PhysicalAssetRequirementHasValuesOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetRequirementHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetRequirementHasValuesOfRelationship? left, PhysicalAssetRequirementHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetRequirementHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}