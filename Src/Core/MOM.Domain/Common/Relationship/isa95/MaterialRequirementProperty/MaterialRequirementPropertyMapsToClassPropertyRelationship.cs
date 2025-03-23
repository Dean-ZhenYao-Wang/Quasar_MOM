namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirementProperty
{
    public class MaterialRequirementPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>, IEquatable<MaterialRequirementPropertyMapsToClassPropertyRelationship>
    {
        public MaterialRequirementPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public MaterialRequirementPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementPropertyMapsToClassPropertyRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(MaterialRequirementPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementPropertyMapsToClassPropertyRelationship? left, MaterialRequirementPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<MaterialRequirementPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementPropertyMapsToClassPropertyRelationship? left, MaterialRequirementPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}