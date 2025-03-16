namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PhysicalAssetSpecificationHierarchyScopeRelRelationship>
    {
        public PhysicalAssetSpecificationHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public PhysicalAssetSpecificationHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetSpecificationHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSpecificationHierarchyScopeRelRelationship);
        }

        public bool Equals(PhysicalAssetSpecificationHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetSpecificationHierarchyScopeRelRelationship? left, PhysicalAssetSpecificationHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetSpecificationHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSpecificationHierarchyScopeRelRelationship? left, PhysicalAssetSpecificationHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetSpecificationHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}