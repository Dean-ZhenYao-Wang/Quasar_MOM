namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification
{
    public class PersonnelSegmentSpecificationHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecificationProperty>, IEquatable<PersonnelSegmentSpecificationHasPropertiesOfRelationship>
    {
        public PersonnelSegmentSpecificationHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public PersonnelSegmentSpecificationHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSegmentSpecificationHasPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSegmentSpecificationHasPropertiesOfRelationship);
        }

        public bool Equals(PersonnelSegmentSpecificationHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSegmentSpecificationHasPropertiesOfRelationship? left, PersonnelSegmentSpecificationHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<PersonnelSegmentSpecificationHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSegmentSpecificationHasPropertiesOfRelationship? left, PersonnelSegmentSpecificationHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSegmentSpecificationHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}