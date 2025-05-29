namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecificationProperty
{
    public class MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecificationProperty,Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>, IEquatable<MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship>
    {
        public MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship()
        {
            Name = "mapsToDefinitionProperty";
        }

        public MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship);
        }

        public bool Equals(MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship? left, MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship? right)
        {
            return EqualityComparer<MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship? left, MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}