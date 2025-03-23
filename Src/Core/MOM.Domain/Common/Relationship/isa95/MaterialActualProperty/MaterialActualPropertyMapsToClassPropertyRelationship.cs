namespace MOM.Domain.Common.Relationship.isa95.MaterialActualProperty
{
    public class MaterialActualPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>, IEquatable<MaterialActualPropertyMapsToClassPropertyRelationship>
    {
        public MaterialActualPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public MaterialActualPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialActualPropertyMapsToClassPropertyRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActualPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(MaterialActualPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialActualPropertyMapsToClassPropertyRelationship? left, MaterialActualPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<MaterialActualPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActualPropertyMapsToClassPropertyRelationship? left, MaterialActualPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialActualPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}