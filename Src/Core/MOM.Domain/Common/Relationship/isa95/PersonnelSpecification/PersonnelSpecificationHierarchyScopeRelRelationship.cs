namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PersonnelSpecificationHierarchyScopeRelRelationship>
    {
        public PersonnelSpecificationHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public PersonnelSpecificationHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSpecificationHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecificationHierarchyScopeRelRelationship);
        }

        public bool Equals(PersonnelSpecificationHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSpecificationHierarchyScopeRelRelationship? left, PersonnelSpecificationHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PersonnelSpecificationHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecificationHierarchyScopeRelRelationship? left, PersonnelSpecificationHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSpecificationHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}