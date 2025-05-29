using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.PersonnelClass
{
    public class PersonnelClassIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass ,Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>, IEquatable<PersonnelClassIncludesPropertiesOfRelationship>
    {
        public PersonnelClassIncludesPropertiesOfRelationship():base()
        {
            Name = "includesPropertiesOf";
        }

        public PersonnelClassIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target) : base(source, target)
        {
        }

        public PersonnelClassIncludesPropertiesOfRelationship(Guid? sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        public PersonnelClassIncludesPropertiesOfRelationship(Guid? sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        public PersonnelClassIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        public PersonnelClassIncludesPropertiesOfRelationship(Guid? sourceId, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target, int depth) : base(sourceId, target, depth)
        {
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelClassIncludesPropertiesOfRelationship);
        }

        public bool Equals(PersonnelClassIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelClassIncludesPropertiesOfRelationship? left, PersonnelClassIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<PersonnelClassIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelClassIncludesPropertiesOfRelationship? left, PersonnelClassIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelClassIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}