namespace MOM.Domain.Common.Relationship.isa95.MaterialCapabilityProperty
{
    public class MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>, IEquatable<MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship>
    {
        public MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship()
        {
            Name = "mapsToDefinitionProperty";
        }

        public MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapabilityProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship);
        }

        public bool Equals(MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship? left, MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship? right)
        {
            return EqualityComparer<MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship? left, MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}