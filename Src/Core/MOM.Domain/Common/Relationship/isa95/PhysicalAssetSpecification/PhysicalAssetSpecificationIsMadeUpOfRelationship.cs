namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification>, IEquatable<PhysicalAssetSpecificationIsMadeUpOfRelationship>
    {
        public PhysicalAssetSpecificationIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public PhysicalAssetSpecificationIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSpecificationIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSpecificationIsMadeUpOfRelationship);
        }

        public bool Equals(PhysicalAssetSpecificationIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSpecificationIsMadeUpOfRelationship? left, PhysicalAssetSpecificationIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSpecificationIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSpecificationIsMadeUpOfRelationship? left, PhysicalAssetSpecificationIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSpecificationIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}