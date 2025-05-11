namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationOperationalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PersonnelSpecificationOperationalLocationRelRelationship>
    {
        public PersonnelSpecificationOperationalLocationRelRelationship()
        {
            Name = "operationalLocationRel";
        }

        public PersonnelSpecificationOperationalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSpecificationOperationalLocationRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecificationOperationalLocationRelRelationship);
        }

        public bool Equals(PersonnelSpecificationOperationalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSpecificationOperationalLocationRelRelationship? left, PersonnelSpecificationOperationalLocationRelRelationship? right)
        {
            return EqualityComparer<PersonnelSpecificationOperationalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecificationOperationalLocationRelRelationship? left, PersonnelSpecificationOperationalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSpecificationOperationalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}