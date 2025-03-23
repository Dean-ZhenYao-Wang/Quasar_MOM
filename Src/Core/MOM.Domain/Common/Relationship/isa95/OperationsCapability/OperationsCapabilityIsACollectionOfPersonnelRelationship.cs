namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfPersonnelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>, IEquatable<OperationsCapabilityIsACollectionOfPersonnelRelationship>
    {
        public OperationsCapabilityIsACollectionOfPersonnelRelationship()
        {
            Name = "isACollectionOfPersonnel";
        }

        public OperationsCapabilityIsACollectionOfPersonnelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsCapabilityIsACollectionOfPersonnelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsCapabilityIsACollectionOfPersonnelRelationship);
        }

        public bool Equals(OperationsCapabilityIsACollectionOfPersonnelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsCapabilityIsACollectionOfPersonnelRelationship? left, OperationsCapabilityIsACollectionOfPersonnelRelationship? right)
        {
            return EqualityComparer<OperationsCapabilityIsACollectionOfPersonnelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsCapabilityIsACollectionOfPersonnelRelationship? left, OperationsCapabilityIsACollectionOfPersonnelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsCapabilityIsACollectionOfPersonnelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}