namespace MOM.Domain.Common.Relationship.isa95.ParameterSpecification
{
    public class ParameterSpecificationHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<ParameterSpecificationHierarchyScopeRelRelationship>
    {
        public ParameterSpecificationHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public ParameterSpecificationHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ParameterSpecificationHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ParameterSpecificationHierarchyScopeRelRelationship);
        }

        public bool Equals(ParameterSpecificationHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ParameterSpecificationHierarchyScopeRelRelationship? left, ParameterSpecificationHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<ParameterSpecificationHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ParameterSpecificationHierarchyScopeRelRelationship? left, ParameterSpecificationHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ParameterSpecificationHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}