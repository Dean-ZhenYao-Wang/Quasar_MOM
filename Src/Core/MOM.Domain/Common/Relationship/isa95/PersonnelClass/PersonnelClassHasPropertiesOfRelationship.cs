using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.PersonnelClass
{
    public class PersonnelClassHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>, IEquatable<PersonnelClassHasPropertiesOfRelationship>
    {
        public PersonnelClassHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        [JsonIgnore]
        [ForeignKey(nameof(SourceId))]
        public virtual Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass Source { get; set; }

        public PersonnelClassHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelClassHasPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelClassHasPropertiesOfRelationship);
        }

        public bool Equals(PersonnelClassHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelClassHasPropertiesOfRelationship? left, PersonnelClassHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<PersonnelClassHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelClassHasPropertiesOfRelationship? left, PersonnelClassHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelClassHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}