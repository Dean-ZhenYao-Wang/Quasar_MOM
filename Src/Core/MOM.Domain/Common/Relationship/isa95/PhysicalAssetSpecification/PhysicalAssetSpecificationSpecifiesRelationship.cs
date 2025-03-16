namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationSpecifiesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>, IEquatable<PhysicalAssetSpecificationSpecifiesRelationship>
    {
        public PhysicalAssetSpecificationSpecifiesRelationship()
        {
            Name = "specifies";
        }

        public PhysicalAssetSpecificationSpecifiesRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSpecificationSpecifiesRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSpecificationSpecifiesRelationship);
        }

        public bool Equals(PhysicalAssetSpecificationSpecifiesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSpecificationSpecifiesRelationship? left, PhysicalAssetSpecificationSpecifiesRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSpecificationSpecifiesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSpecificationSpecifiesRelationship? left, PhysicalAssetSpecificationSpecifiesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSpecificationSpecifiesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}