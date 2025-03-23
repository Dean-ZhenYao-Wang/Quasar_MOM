namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfMaterialRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability>, IEquatable<OperationsCapabilityIsACollectionOfMaterialRelationship>
    {
        public OperationsCapabilityIsACollectionOfMaterialRelationship()
        {
            Name = "isACollectionOfMaterial";
        }

        public OperationsCapabilityIsACollectionOfMaterialRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsCapabilityIsACollectionOfMaterialRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsCapabilityIsACollectionOfMaterialRelationship);
        }

        public bool Equals(OperationsCapabilityIsACollectionOfMaterialRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsCapabilityIsACollectionOfMaterialRelationship? left, OperationsCapabilityIsACollectionOfMaterialRelationship? right)
        {
            return EqualityComparer<OperationsCapabilityIsACollectionOfMaterialRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsCapabilityIsACollectionOfMaterialRelationship? left, OperationsCapabilityIsACollectionOfMaterialRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsCapabilityIsACollectionOfMaterialRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}