namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecificationProperty
{
    public class PersonnelSegmentSpecificationPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecificationProperty>, IEquatable<PersonnelSegmentSpecificationPropertyContainsRelationship>
    {
        public PersonnelSegmentSpecificationPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public PersonnelSegmentSpecificationPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSegmentSpecificationPropertyContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSegmentSpecificationPropertyContainsRelationship);
        }

        public bool Equals(PersonnelSegmentSpecificationPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSegmentSpecificationPropertyContainsRelationship? left, PersonnelSegmentSpecificationPropertyContainsRelationship? right)
        {
            return EqualityComparer<PersonnelSegmentSpecificationPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSegmentSpecificationPropertyContainsRelationship? left, PersonnelSegmentSpecificationPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSegmentSpecificationPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}