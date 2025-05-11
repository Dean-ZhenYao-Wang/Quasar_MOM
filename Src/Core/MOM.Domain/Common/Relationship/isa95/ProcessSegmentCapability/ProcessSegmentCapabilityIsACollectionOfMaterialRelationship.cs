namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityIsACollectionOfMaterialRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability>, IEquatable<ProcessSegmentCapabilityIsACollectionOfMaterialRelationship>
    {
        public ProcessSegmentCapabilityIsACollectionOfMaterialRelationship()
        {
            Name = "isACollectionOfMaterial";
        }

        public ProcessSegmentCapabilityIsACollectionOfMaterialRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentCapabilityIsACollectionOfMaterialRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentCapabilityIsACollectionOfMaterialRelationship);
        }

        public bool Equals(ProcessSegmentCapabilityIsACollectionOfMaterialRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentCapabilityIsACollectionOfMaterialRelationship? left, ProcessSegmentCapabilityIsACollectionOfMaterialRelationship? right)
        {
            return EqualityComparer<ProcessSegmentCapabilityIsACollectionOfMaterialRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentCapabilityIsACollectionOfMaterialRelationship? left, ProcessSegmentCapabilityIsACollectionOfMaterialRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentCapabilityIsACollectionOfMaterialRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}