namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinition
{
    public class OperationsEventDefinitionHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<OperationsEventDefinitionHierarchyScopeRelRelationship>
    {
        public OperationsEventDefinitionHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public OperationsEventDefinitionHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinition source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventDefinitionHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinitionHierarchyScopeRelRelationship);
        }

        public bool Equals(OperationsEventDefinitionHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventDefinitionHierarchyScopeRelRelationship? left, OperationsEventDefinitionHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<OperationsEventDefinitionHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinitionHierarchyScopeRelRelationship? left, OperationsEventDefinitionHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventDefinitionHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}