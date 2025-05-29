namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityStorageLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability ,Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<MaterialCapabilityStorageLocationRelRelationship>
    {
        public MaterialCapabilityStorageLocationRelRelationship()
        {
            Name = "storageLocationRel";
        }

        public MaterialCapabilityStorageLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialCapabilityStorageLocationRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapabilityStorageLocationRelRelationship);
        }

        public bool Equals(MaterialCapabilityStorageLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialCapabilityStorageLocationRelRelationship? left, MaterialCapabilityStorageLocationRelRelationship? right)
        {
            return EqualityComparer<MaterialCapabilityStorageLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapabilityStorageLocationRelRelationship? left, MaterialCapabilityStorageLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialCapabilityStorageLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}