namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>, IEquatable<OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship>
    {
        public OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship()
        {
            Name = "isACollectionOfPersonnel";
        }

        public OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship);
        }

        public bool Equals(OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship? left, OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship? right)
        {
            return EqualityComparer<OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship? left, OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}