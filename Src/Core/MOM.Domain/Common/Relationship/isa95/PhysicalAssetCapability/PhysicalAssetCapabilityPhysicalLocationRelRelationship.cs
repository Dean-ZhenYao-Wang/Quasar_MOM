namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability
{
    public class PhysicalAssetCapabilityPhysicalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PhysicalAssetCapabilityPhysicalLocationRelRelationship>
    {
        public PhysicalAssetCapabilityPhysicalLocationRelRelationship()
        {
            Name = "physicalLocationRel";
        }

        public PhysicalAssetCapabilityPhysicalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetCapabilityPhysicalLocationRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetCapabilityPhysicalLocationRelRelationship);
        }

        public bool Equals(PhysicalAssetCapabilityPhysicalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetCapabilityPhysicalLocationRelRelationship? left, PhysicalAssetCapabilityPhysicalLocationRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetCapabilityPhysicalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetCapabilityPhysicalLocationRelRelationship? left, PhysicalAssetCapabilityPhysicalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetCapabilityPhysicalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}