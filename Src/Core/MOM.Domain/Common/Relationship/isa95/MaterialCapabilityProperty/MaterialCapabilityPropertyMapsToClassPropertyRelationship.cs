namespace MOM.Domain.Common.Relationship.isa95.MaterialCapabilityProperty
{
    public class MaterialCapabilityPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>, IEquatable<MaterialCapabilityPropertyMapsToClassPropertyRelationship>
    {
        public MaterialCapabilityPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public MaterialCapabilityPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapabilityProperty source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialCapabilityPropertyMapsToClassPropertyRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapabilityPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(MaterialCapabilityPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialCapabilityPropertyMapsToClassPropertyRelationship? left, MaterialCapabilityPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<MaterialCapabilityPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapabilityPropertyMapsToClassPropertyRelationship? left, MaterialCapabilityPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialCapabilityPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}