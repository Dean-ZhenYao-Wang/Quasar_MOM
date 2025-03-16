namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability>, IEquatable<ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship>
    {
        public ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship()
        {
            Name = "isACollectionOfEquipment";
        }

        public ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.EquipmentCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship);
        }

        public bool Equals(ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship? left, ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship? right)
        {
            return EqualityComparer<ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship? left, ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentCapabilityIsACollectionOfEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}