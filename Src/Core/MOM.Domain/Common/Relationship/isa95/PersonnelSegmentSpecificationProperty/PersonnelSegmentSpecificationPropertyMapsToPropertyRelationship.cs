namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecificationProperty
{
    public class PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>, IEquatable<PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship>
    {
        public PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship);
        }

        public bool Equals(PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship? left, PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship? left, PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}