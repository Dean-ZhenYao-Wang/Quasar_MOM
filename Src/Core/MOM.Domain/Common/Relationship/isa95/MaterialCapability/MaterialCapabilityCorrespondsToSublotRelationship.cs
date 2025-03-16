namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityCorrespondsToSublotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>, IEquatable<MaterialCapabilityCorrespondsToSublotRelationship>
    {
        public MaterialCapabilityCorrespondsToSublotRelationship()
        {
            Name = "correspondsToSublot";
        }

        public MaterialCapabilityCorrespondsToSublotRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialCapabilityCorrespondsToSublotRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapabilityCorrespondsToSublotRelationship);
        }

        public bool Equals(MaterialCapabilityCorrespondsToSublotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialCapabilityCorrespondsToSublotRelationship? left, MaterialCapabilityCorrespondsToSublotRelationship? right)
        {
            return EqualityComparer<MaterialCapabilityCorrespondsToSublotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapabilityCorrespondsToSublotRelationship? left, MaterialCapabilityCorrespondsToSublotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialCapabilityCorrespondsToSublotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}