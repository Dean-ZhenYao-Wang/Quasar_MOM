namespace MOM.Domain.Common.Relationship.isa95.PhysicalAsset
{
    public class PhysicalAssetPhysicalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PhysicalAssetPhysicalLocationRelRelationship>
    {
        public PhysicalAssetPhysicalLocationRelRelationship()
        {
            Name = "physicalLocationRel";
        }

        public PhysicalAssetPhysicalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetPhysicalLocationRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetPhysicalLocationRelRelationship);
        }

        public bool Equals(PhysicalAssetPhysicalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetPhysicalLocationRelRelationship? left, PhysicalAssetPhysicalLocationRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetPhysicalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetPhysicalLocationRelRelationship? left, PhysicalAssetPhysicalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetPhysicalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}