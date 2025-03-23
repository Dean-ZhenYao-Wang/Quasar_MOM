namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecificationProperty
{
    public class PhysicalAssetSpecificationPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecificationProperty>, IEquatable<PhysicalAssetSpecificationPropertyContainsRelationship>
    {
        public PhysicalAssetSpecificationPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public PhysicalAssetSpecificationPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSpecificationPropertyContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSpecificationPropertyContainsRelationship);
        }

        public bool Equals(PhysicalAssetSpecificationPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSpecificationPropertyContainsRelationship? left, PhysicalAssetSpecificationPropertyContainsRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSpecificationPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSpecificationPropertyContainsRelationship? left, PhysicalAssetSpecificationPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSpecificationPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}