namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecificationProperty
{
    public class PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>, IEquatable<PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship>
    {
        public PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship? left, PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship? left, PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}