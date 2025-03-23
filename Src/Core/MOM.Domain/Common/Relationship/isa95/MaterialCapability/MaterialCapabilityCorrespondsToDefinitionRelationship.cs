namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityCorrespondsToDefinitionRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>, IEquatable<MaterialCapabilityCorrespondsToDefinitionRelationship>
    {
        public MaterialCapabilityCorrespondsToDefinitionRelationship()
        {
            Name = "correspondsToDefinition";
        }

        public MaterialCapabilityCorrespondsToDefinitionRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialCapabilityCorrespondsToDefinitionRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapabilityCorrespondsToDefinitionRelationship);
        }

        public bool Equals(MaterialCapabilityCorrespondsToDefinitionRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialCapabilityCorrespondsToDefinitionRelationship? left, MaterialCapabilityCorrespondsToDefinitionRelationship? right)
        {
            return EqualityComparer<MaterialCapabilityCorrespondsToDefinitionRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapabilityCorrespondsToDefinitionRelationship? left, MaterialCapabilityCorrespondsToDefinitionRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialCapabilityCorrespondsToDefinitionRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}