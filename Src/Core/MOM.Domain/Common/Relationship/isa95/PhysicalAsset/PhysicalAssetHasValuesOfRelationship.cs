namespace MOM.Domain.Common.Relationship.isa95.PhysicalAsset
{
    public class PhysicalAssetHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>, IEquatable<PhysicalAssetHasValuesOfRelationship>
    {
        public PhysicalAssetHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public PhysicalAssetHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetHasValuesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetHasValuesOfRelationship);
        }

        public bool Equals(PhysicalAssetHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetHasValuesOfRelationship? left, PhysicalAssetHasValuesOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetHasValuesOfRelationship? left, PhysicalAssetHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}