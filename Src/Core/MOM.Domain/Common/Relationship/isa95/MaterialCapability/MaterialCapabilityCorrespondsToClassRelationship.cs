namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityCorrespondsToClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability,Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>, IEquatable<MaterialCapabilityCorrespondsToClassRelationship>
    {
        public MaterialCapabilityCorrespondsToClassRelationship()
        {
            Name = "correspondsToClass";
        }

        public MaterialCapabilityCorrespondsToClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialCapabilityCorrespondsToClassRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapabilityCorrespondsToClassRelationship);
        }

        public bool Equals(MaterialCapabilityCorrespondsToClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialCapabilityCorrespondsToClassRelationship? left, MaterialCapabilityCorrespondsToClassRelationship? right)
        {
            return EqualityComparer<MaterialCapabilityCorrespondsToClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapabilityCorrespondsToClassRelationship? left, MaterialCapabilityCorrespondsToClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialCapabilityCorrespondsToClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}