namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityIsACollectionOfEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability>, IEquatable<WorkMasterCapabilityIsACollectionOfEquipmentRelationship>
    {
        public WorkMasterCapabilityIsACollectionOfEquipmentRelationship()
        {
            Name = "isACollectionOfEquipment";
        }

        public WorkMasterCapabilityIsACollectionOfEquipmentRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkMasterCapabilityIsACollectionOfEquipmentRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterCapabilityIsACollectionOfEquipmentRelationship);
        }

        public bool Equals(WorkMasterCapabilityIsACollectionOfEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkMasterCapabilityIsACollectionOfEquipmentRelationship? left, WorkMasterCapabilityIsACollectionOfEquipmentRelationship? right)
        {
            return EqualityComparer<WorkMasterCapabilityIsACollectionOfEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterCapabilityIsACollectionOfEquipmentRelationship? left, WorkMasterCapabilityIsACollectionOfEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkMasterCapabilityIsACollectionOfEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}