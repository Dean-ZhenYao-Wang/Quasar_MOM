

namespace MOM.Domain.Common.Relationship.isa95.Person
{
    public partial class PersonDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.Person,Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>, IEquatable<PersonDefinedByRelationship>
    {
        public PersonDefinedByRelationship():base()
        {
            Name = "definedBy";
        }

        public PersonDefinedByRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.Person source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target) : base(source, target)
        {
        }

        public PersonDefinedByRelationship(Guid? sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        public PersonDefinedByRelationship(Guid? sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        public PersonDefinedByRelationship(Guid? sourceId, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target, int depth) : base(sourceId, target, depth)
        {
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonDefinedByRelationship);
        }

        public bool Equals(PersonDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonDefinedByRelationship? left, PersonDefinedByRelationship? right)
        {
            return EqualityComparer<PersonDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonDefinedByRelationship? left, PersonDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}