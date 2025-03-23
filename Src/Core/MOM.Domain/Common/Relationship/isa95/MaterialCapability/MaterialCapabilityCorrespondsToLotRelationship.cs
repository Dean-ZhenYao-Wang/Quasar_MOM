namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityCorrespondsToLotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>, IEquatable<MaterialCapabilityCorrespondsToLotRelationship>
    {
        public MaterialCapabilityCorrespondsToLotRelationship()
        {
            Name = "correspondsToLot";
        }

        public MaterialCapabilityCorrespondsToLotRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialCapabilityCorrespondsToLotRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapabilityCorrespondsToLotRelationship);
        }

        public bool Equals(MaterialCapabilityCorrespondsToLotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialCapabilityCorrespondsToLotRelationship? left, MaterialCapabilityCorrespondsToLotRelationship? right)
        {
            return EqualityComparer<MaterialCapabilityCorrespondsToLotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapabilityCorrespondsToLotRelationship? left, MaterialCapabilityCorrespondsToLotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialCapabilityCorrespondsToLotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}