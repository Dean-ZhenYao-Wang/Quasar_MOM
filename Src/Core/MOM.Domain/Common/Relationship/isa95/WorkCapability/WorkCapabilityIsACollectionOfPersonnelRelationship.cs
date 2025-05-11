namespace MOM.Domain.Common.Relationship.isa95.WorkCapability
{
    public class WorkCapabilityIsACollectionOfPersonnelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>, IEquatable<WorkCapabilityIsACollectionOfPersonnelRelationship>
    {
        public WorkCapabilityIsACollectionOfPersonnelRelationship()
        {
            Name = "isACollectionOfPersonnel";
        }

        public WorkCapabilityIsACollectionOfPersonnelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCapabilityIsACollectionOfPersonnelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCapabilityIsACollectionOfPersonnelRelationship);
        }

        public bool Equals(WorkCapabilityIsACollectionOfPersonnelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCapabilityIsACollectionOfPersonnelRelationship? left, WorkCapabilityIsACollectionOfPersonnelRelationship? right)
        {
            return EqualityComparer<WorkCapabilityIsACollectionOfPersonnelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCapabilityIsACollectionOfPersonnelRelationship? left, WorkCapabilityIsACollectionOfPersonnelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCapabilityIsACollectionOfPersonnelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}