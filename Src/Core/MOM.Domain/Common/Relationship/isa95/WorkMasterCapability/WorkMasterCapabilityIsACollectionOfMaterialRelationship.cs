namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityIsACollectionOfMaterialRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability>, IEquatable<WorkMasterCapabilityIsACollectionOfMaterialRelationship>
    {
        public WorkMasterCapabilityIsACollectionOfMaterialRelationship()
        {
            Name = "isACollectionOfMaterial";
        }

        public WorkMasterCapabilityIsACollectionOfMaterialRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkMasterCapabilityIsACollectionOfMaterialRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterCapabilityIsACollectionOfMaterialRelationship);
        }

        public bool Equals(WorkMasterCapabilityIsACollectionOfMaterialRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkMasterCapabilityIsACollectionOfMaterialRelationship? left, WorkMasterCapabilityIsACollectionOfMaterialRelationship? right)
        {
            return EqualityComparer<WorkMasterCapabilityIsACollectionOfMaterialRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterCapabilityIsACollectionOfMaterialRelationship? left, WorkMasterCapabilityIsACollectionOfMaterialRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkMasterCapabilityIsACollectionOfMaterialRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}