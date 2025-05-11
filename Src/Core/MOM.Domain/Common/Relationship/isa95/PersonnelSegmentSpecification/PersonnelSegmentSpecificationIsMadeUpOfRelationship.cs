namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification
{
    public class PersonnelSegmentSpecificationIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecification>, IEquatable<PersonnelSegmentSpecificationIsMadeUpOfRelationship>
    {
        public PersonnelSegmentSpecificationIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public PersonnelSegmentSpecificationIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSegmentSpecificationIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSegmentSpecificationIsMadeUpOfRelationship);
        }

        public bool Equals(PersonnelSegmentSpecificationIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSegmentSpecificationIsMadeUpOfRelationship? left, PersonnelSegmentSpecificationIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PersonnelSegmentSpecificationIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSegmentSpecificationIsMadeUpOfRelationship? left, PersonnelSegmentSpecificationIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSegmentSpecificationIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}