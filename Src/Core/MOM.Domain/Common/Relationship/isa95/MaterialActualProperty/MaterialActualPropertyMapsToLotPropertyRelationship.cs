namespace MOM.Domain.Common.Relationship.isa95.MaterialActualProperty
{
    public class MaterialActualPropertyMapsToLotPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty ,Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>, IEquatable<MaterialActualPropertyMapsToLotPropertyRelationship>
    {
        public MaterialActualPropertyMapsToLotPropertyRelationship()
        {
            Name = "mapsToLotProperty";
        }

        public MaterialActualPropertyMapsToLotPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialActualPropertyMapsToLotPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActualPropertyMapsToLotPropertyRelationship);
        }

        public bool Equals(MaterialActualPropertyMapsToLotPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialActualPropertyMapsToLotPropertyRelationship? left, MaterialActualPropertyMapsToLotPropertyRelationship? right)
        {
            return EqualityComparer<MaterialActualPropertyMapsToLotPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActualPropertyMapsToLotPropertyRelationship? left, MaterialActualPropertyMapsToLotPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialActualPropertyMapsToLotPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}