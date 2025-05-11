namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetProperty
{
    public class PhysicalAssetPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>, IEquatable<PhysicalAssetPropertyContainsRelationship>
    {
        public PhysicalAssetPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public PhysicalAssetPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetPropertyContainsRelationship);
        }

        public bool Equals(PhysicalAssetPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetPropertyContainsRelationship? left, PhysicalAssetPropertyContainsRelationship? right)
        {
            return EqualityComparer<PhysicalAssetPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetPropertyContainsRelationship? left, PhysicalAssetPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}