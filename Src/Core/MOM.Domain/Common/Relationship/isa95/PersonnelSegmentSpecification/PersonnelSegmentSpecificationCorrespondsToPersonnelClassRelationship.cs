namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification
{
    public class PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>, IEquatable<PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship>
    {
        public PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship()
        {
            Name = "correspondsToPersonnelClass";
        }

        public PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship);
        }

        public bool Equals(PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship? left, PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship? right)
        {
            return EqualityComparer<PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship? left, PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}