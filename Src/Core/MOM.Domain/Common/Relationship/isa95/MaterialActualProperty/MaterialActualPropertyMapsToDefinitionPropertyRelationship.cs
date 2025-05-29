namespace MOM.Domain.Common.Relationship.isa95.MaterialActualProperty
{
    public class MaterialActualPropertyMapsToDefinitionPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty,Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>, IEquatable<MaterialActualPropertyMapsToDefinitionPropertyRelationship>
    {
        public MaterialActualPropertyMapsToDefinitionPropertyRelationship()
        {
            Name = "mapsToDefinitionProperty";
        }

        public MaterialActualPropertyMapsToDefinitionPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialActualPropertyMapsToDefinitionPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActualPropertyMapsToDefinitionPropertyRelationship);
        }

        public bool Equals(MaterialActualPropertyMapsToDefinitionPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialActualPropertyMapsToDefinitionPropertyRelationship? left, MaterialActualPropertyMapsToDefinitionPropertyRelationship? right)
        {
            return EqualityComparer<MaterialActualPropertyMapsToDefinitionPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActualPropertyMapsToDefinitionPropertyRelationship? left, MaterialActualPropertyMapsToDefinitionPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialActualPropertyMapsToDefinitionPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}