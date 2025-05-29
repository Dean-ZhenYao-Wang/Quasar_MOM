
namespace MOM.Domain.Common.Relationship.isa95.PersonProperty
{
    public partial class PersonPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty,Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>, IEquatable<PersonPropertyContainsRelationship>
    {
        public PersonPropertyContainsRelationship():base()
        {
            Name = "contains";
        }

        public PersonPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty target) : base(source, target)
        {
        }

        public PersonPropertyContainsRelationship(Guid? sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        public PersonPropertyContainsRelationship(Guid? sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        public PersonPropertyContainsRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        public PersonPropertyContainsRelationship(Guid? sourceId, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty target, int depth) : base(sourceId, target, depth)
        {
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonPropertyContainsRelationship);
        }

        public bool Equals(PersonPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonPropertyContainsRelationship? left, PersonPropertyContainsRelationship? right)
        {
            return EqualityComparer<PersonPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonPropertyContainsRelationship? left, PersonPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}