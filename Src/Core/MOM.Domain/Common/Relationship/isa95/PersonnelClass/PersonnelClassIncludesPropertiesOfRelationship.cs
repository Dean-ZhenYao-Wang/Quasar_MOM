using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.PersonnelClass
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonnelClassIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>, IEquatable<PersonnelClassIncludesPropertiesOfRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "includesPropertiesOf";
        /// <inheritdoc/>
        public PersonnelClassIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public PersonnelClassIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public PersonnelClassIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public PersonnelClassIncludesPropertiesOfRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelClassIncludesPropertiesOfRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(PersonnelClassIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(PersonnelClassIncludesPropertiesOfRelationship? left, PersonnelClassIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<PersonnelClassIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PersonnelClassIncludesPropertiesOfRelationship? left, PersonnelClassIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        /// <inheritdoc/>
        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelClassIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}