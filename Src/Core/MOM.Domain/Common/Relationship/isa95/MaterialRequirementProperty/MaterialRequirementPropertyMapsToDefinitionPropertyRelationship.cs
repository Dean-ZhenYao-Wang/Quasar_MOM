namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirementProperty
{
    public class MaterialRequirementPropertyMapsToDefinitionPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>, IEquatable<MaterialRequirementPropertyMapsToDefinitionPropertyRelationship>
    {
        public MaterialRequirementPropertyMapsToDefinitionPropertyRelationship()
        {
            Name = "mapsToDefinitionProperty";
        }

        public MaterialRequirementPropertyMapsToDefinitionPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementPropertyMapsToDefinitionPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementPropertyMapsToDefinitionPropertyRelationship);
        }

        public bool Equals(MaterialRequirementPropertyMapsToDefinitionPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementPropertyMapsToDefinitionPropertyRelationship? left, MaterialRequirementPropertyMapsToDefinitionPropertyRelationship? right)
        {
            return EqualityComparer<MaterialRequirementPropertyMapsToDefinitionPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementPropertyMapsToDefinitionPropertyRelationship? left, MaterialRequirementPropertyMapsToDefinitionPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementPropertyMapsToDefinitionPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}