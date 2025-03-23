namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecificationProperty>, IEquatable<PhysicalAssetSpecificationHasPropertiesOfRelationship>
    {
        public PhysicalAssetSpecificationHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public PhysicalAssetSpecificationHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSpecificationHasPropertiesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSpecificationHasPropertiesOfRelationship);
        }

        public bool Equals(PhysicalAssetSpecificationHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSpecificationHasPropertiesOfRelationship? left, PhysicalAssetSpecificationHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSpecificationHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSpecificationHasPropertiesOfRelationship? left, PhysicalAssetSpecificationHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSpecificationHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}