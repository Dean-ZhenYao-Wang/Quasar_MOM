namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PersonnelActualHierarchyScopeRelRelationship>
    {
        public PersonnelActualHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public PersonnelActualHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelActualHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelActualHierarchyScopeRelRelationship);
        }

        public bool Equals(PersonnelActualHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelActualHierarchyScopeRelRelationship? left, PersonnelActualHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PersonnelActualHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelActualHierarchyScopeRelRelationship? left, PersonnelActualHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelActualHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}