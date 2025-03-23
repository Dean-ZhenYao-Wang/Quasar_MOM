namespace MOM.Domain.Common.Relationship.isa95.MaterialCapabilityProperty
{
    public class MaterialCapabilityPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapabilityProperty>, IEquatable<MaterialCapabilityPropertyContainsRelationship>
    {
        public MaterialCapabilityPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public MaterialCapabilityPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapabilityProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapabilityProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialCapabilityPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapabilityPropertyContainsRelationship);
        }

        public bool Equals(MaterialCapabilityPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialCapabilityPropertyContainsRelationship? left, MaterialCapabilityPropertyContainsRelationship? right)
        {
            return EqualityComparer<MaterialCapabilityPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapabilityPropertyContainsRelationship? left, MaterialCapabilityPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialCapabilityPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}