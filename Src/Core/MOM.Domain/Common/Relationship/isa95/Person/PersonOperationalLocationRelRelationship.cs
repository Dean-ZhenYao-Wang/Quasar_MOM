
namespace MOM.Domain.Common.Relationship.isa95.Person
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonOperationalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.Person ,Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PersonOperationalLocationRelRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "operationalLocationRel";
        /// <inheritdoc/>
        public PersonOperationalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.Person source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public PersonOperationalLocationRelRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public PersonOperationalLocationRelRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public PersonOperationalLocationRelRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonOperationalLocationRelRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(PersonOperationalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(PersonOperationalLocationRelRelationship? left, PersonOperationalLocationRelRelationship? right)
        {
            return EqualityComparer<PersonOperationalLocationRelRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PersonOperationalLocationRelRelationship? left, PersonOperationalLocationRelRelationship? right)
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
            return Equals(other as PersonOperationalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}