using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.Person
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.Person ,Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PersonHierarchyScopeRelRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "hierarchyScopeRel";
        /// <inheritdoc/>
        public PersonHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.Person source, Domain.isa95.CommonObjectModels.HierarchyScope target) : base(source, target)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="targetId"></param>
        public PersonHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public PersonHierarchyScopeRelRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public PersonHierarchyScopeRelRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.HierarchyScope target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonHierarchyScopeRelRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(PersonHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(PersonHierarchyScopeRelRelationship? left, PersonHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PersonHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PersonHierarchyScopeRelRelationship? left, PersonHierarchyScopeRelRelationship? right)
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
            return Equals(other as PersonHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}