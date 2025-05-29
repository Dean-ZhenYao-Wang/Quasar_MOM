using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.PersonnelClassProperty
{
    public class PersonnelClassPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty,Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>, IEquatable<PersonnelClassPropertyContainsRelationship>
    {
        public PersonnelClassPropertyContainsRelationship():base()
        {
            Name = "contains";
        }

        public PersonnelClassPropertyContainsRelationship(Guid? sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        public PersonnelClassPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty target) : base(source, target)
        {
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelClassPropertyContainsRelationship);
        }

        public bool Equals(PersonnelClassPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelClassPropertyContainsRelationship? left, PersonnelClassPropertyContainsRelationship? right)
        {
            return EqualityComparer<PersonnelClassPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelClassPropertyContainsRelationship? left, PersonnelClassPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelClassPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}