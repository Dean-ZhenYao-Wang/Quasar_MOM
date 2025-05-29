namespace MOM.Domain.Common.Relationship.isa95.MaterialCapabilityProperty
{
    public class MaterialCapabilityPropertyMapsToLotPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapabilityProperty,Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>, IEquatable<MaterialCapabilityPropertyMapsToLotPropertyRelationship>
    {
        public MaterialCapabilityPropertyMapsToLotPropertyRelationship()
        {
            Name = "mapsToLotProperty";
        }

        public MaterialCapabilityPropertyMapsToLotPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapabilityProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialCapabilityPropertyMapsToLotPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapabilityPropertyMapsToLotPropertyRelationship);
        }

        public bool Equals(MaterialCapabilityPropertyMapsToLotPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialCapabilityPropertyMapsToLotPropertyRelationship? left, MaterialCapabilityPropertyMapsToLotPropertyRelationship? right)
        {
            return EqualityComparer<MaterialCapabilityPropertyMapsToLotPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapabilityPropertyMapsToLotPropertyRelationship? left, MaterialCapabilityPropertyMapsToLotPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialCapabilityPropertyMapsToLotPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}