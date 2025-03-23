namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>, IEquatable<ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship>
    {
        public ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship()
        {
            Name = "isACollectionOfPersonnel";
        }

        public ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship);
        }

        public bool Equals(ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship? left, ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship? right)
        {
            return EqualityComparer<ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship? left, ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}