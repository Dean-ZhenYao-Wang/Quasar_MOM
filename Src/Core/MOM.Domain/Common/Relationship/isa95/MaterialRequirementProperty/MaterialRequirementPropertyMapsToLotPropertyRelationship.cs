namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirementProperty
{
    public class MaterialRequirementPropertyMapsToLotPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>, IEquatable<MaterialRequirementPropertyMapsToLotPropertyRelationship>
    {
        public MaterialRequirementPropertyMapsToLotPropertyRelationship()
        {
            Name = "mapsToLotProperty";
        }

        public MaterialRequirementPropertyMapsToLotPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementPropertyMapsToLotPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementPropertyMapsToLotPropertyRelationship);
        }

        public bool Equals(MaterialRequirementPropertyMapsToLotPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementPropertyMapsToLotPropertyRelationship? left, MaterialRequirementPropertyMapsToLotPropertyRelationship? right)
        {
            return EqualityComparer<MaterialRequirementPropertyMapsToLotPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementPropertyMapsToLotPropertyRelationship? left, MaterialRequirementPropertyMapsToLotPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementPropertyMapsToLotPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}