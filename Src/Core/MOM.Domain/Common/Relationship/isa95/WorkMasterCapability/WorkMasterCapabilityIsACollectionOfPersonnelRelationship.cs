namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityIsACollectionOfPersonnelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>, IEquatable<WorkMasterCapabilityIsACollectionOfPersonnelRelationship>
    {
        public WorkMasterCapabilityIsACollectionOfPersonnelRelationship()
        {
            Name = "isACollectionOfPersonnel";
        }

        public WorkMasterCapabilityIsACollectionOfPersonnelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkMasterCapabilityIsACollectionOfPersonnelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterCapabilityIsACollectionOfPersonnelRelationship);
        }

        public bool Equals(WorkMasterCapabilityIsACollectionOfPersonnelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkMasterCapabilityIsACollectionOfPersonnelRelationship? left, WorkMasterCapabilityIsACollectionOfPersonnelRelationship? right)
        {
            return EqualityComparer<WorkMasterCapabilityIsACollectionOfPersonnelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterCapabilityIsACollectionOfPersonnelRelationship? left, WorkMasterCapabilityIsACollectionOfPersonnelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkMasterCapabilityIsACollectionOfPersonnelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}