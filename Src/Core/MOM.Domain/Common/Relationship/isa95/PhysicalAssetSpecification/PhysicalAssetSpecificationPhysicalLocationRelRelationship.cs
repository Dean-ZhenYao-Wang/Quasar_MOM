namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationPhysicalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PhysicalAssetSpecificationPhysicalLocationRelRelationship>
    {
        public PhysicalAssetSpecificationPhysicalLocationRelRelationship()
        {
            Name = "physicalLocationRel";
        }

        public PhysicalAssetSpecificationPhysicalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSpecificationPhysicalLocationRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSpecificationPhysicalLocationRelRelationship);
        }

        public bool Equals(PhysicalAssetSpecificationPhysicalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSpecificationPhysicalLocationRelRelationship? left, PhysicalAssetSpecificationPhysicalLocationRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSpecificationPhysicalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSpecificationPhysicalLocationRelRelationship? left, PhysicalAssetSpecificationPhysicalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSpecificationPhysicalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}