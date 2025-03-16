namespace MOM.Domain.Common.Relationship.isa95.WorkCapability
{
    public class WorkCapabilityIsACollectionOfMaterialRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability>, IEquatable<WorkCapabilityIsACollectionOfMaterialRelationship>
    {
        public WorkCapabilityIsACollectionOfMaterialRelationship()
        {
            Name = "isACollectionOfMaterial";
        }

        public WorkCapabilityIsACollectionOfMaterialRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCapabilityIsACollectionOfMaterialRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCapabilityIsACollectionOfMaterialRelationship);
        }

        public bool Equals(WorkCapabilityIsACollectionOfMaterialRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCapabilityIsACollectionOfMaterialRelationship? left, WorkCapabilityIsACollectionOfMaterialRelationship? right)
        {
            return EqualityComparer<WorkCapabilityIsACollectionOfMaterialRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCapabilityIsACollectionOfMaterialRelationship? left, WorkCapabilityIsACollectionOfMaterialRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCapabilityIsACollectionOfMaterialRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}