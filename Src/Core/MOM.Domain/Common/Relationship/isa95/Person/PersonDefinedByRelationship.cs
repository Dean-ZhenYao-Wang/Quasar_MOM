namespace MOM.Domain.Common.Relationship.isa95.Person
{
    /// <summary>
    ///
    /// </summary>
    public partial class PersonDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.Person, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>, IEquatable<PersonDefinedByRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "definedBy";

        /// <inheritdoc/>
        public PersonDefinedByRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.Person source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target) : base(source, target)
        {
        }

        /// <inheritdoc/>
        public PersonDefinedByRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        /// <inheritdoc/>
        public PersonDefinedByRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        /// <inheritdoc/>
        public PersonDefinedByRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonDefinedByRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(PersonDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(PersonDefinedByRelationship? left, PersonDefinedByRelationship? right)
        {
            return EqualityComparer<PersonDefinedByRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PersonDefinedByRelationship? left, PersonDefinedByRelationship? right)
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
            return Equals(other as PersonDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}