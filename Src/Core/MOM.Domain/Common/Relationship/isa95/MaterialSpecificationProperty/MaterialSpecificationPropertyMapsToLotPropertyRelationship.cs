namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecificationProperty
{
    public class MaterialSpecificationPropertyMapsToLotPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>, IEquatable<MaterialSpecificationPropertyMapsToLotPropertyRelationship>
    {
        public MaterialSpecificationPropertyMapsToLotPropertyRelationship()
        {
            Name = "mapsToLotProperty";
        }

        public MaterialSpecificationPropertyMapsToLotPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSpecificationPropertyMapsToLotPropertyRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecificationPropertyMapsToLotPropertyRelationship);
        }

        public bool Equals(MaterialSpecificationPropertyMapsToLotPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSpecificationPropertyMapsToLotPropertyRelationship? left, MaterialSpecificationPropertyMapsToLotPropertyRelationship? right)
        {
            return EqualityComparer<MaterialSpecificationPropertyMapsToLotPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecificationPropertyMapsToLotPropertyRelationship? left, MaterialSpecificationPropertyMapsToLotPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSpecificationPropertyMapsToLotPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}