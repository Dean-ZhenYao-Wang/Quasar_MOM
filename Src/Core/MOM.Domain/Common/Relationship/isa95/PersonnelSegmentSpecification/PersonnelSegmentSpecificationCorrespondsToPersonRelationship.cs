namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification
{
    public class PersonnelSegmentSpecificationCorrespondsToPersonRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.Person>, IEquatable<PersonnelSegmentSpecificationCorrespondsToPersonRelationship>
    {
        public PersonnelSegmentSpecificationCorrespondsToPersonRelationship()
        {
            Name = "correspondsToPerson";
        }

        public PersonnelSegmentSpecificationCorrespondsToPersonRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.Personnel.Person target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSegmentSpecificationCorrespondsToPersonRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSegmentSpecificationCorrespondsToPersonRelationship);
        }

        public bool Equals(PersonnelSegmentSpecificationCorrespondsToPersonRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSegmentSpecificationCorrespondsToPersonRelationship? left, PersonnelSegmentSpecificationCorrespondsToPersonRelationship? right)
        {
            return EqualityComparer<PersonnelSegmentSpecificationCorrespondsToPersonRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSegmentSpecificationCorrespondsToPersonRelationship? left, PersonnelSegmentSpecificationCorrespondsToPersonRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSegmentSpecificationCorrespondsToPersonRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}