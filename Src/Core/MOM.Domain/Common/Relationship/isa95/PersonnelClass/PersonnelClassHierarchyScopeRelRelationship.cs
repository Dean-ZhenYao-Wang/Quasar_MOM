using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.PersonnelClass
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonnelClassHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass ,Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PersonnelClassHierarchyScopeRelRelationship>
    {
        /// <inheritdoc/>
        public PersonnelClassHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }
        /// <inheritdoc/>
        public PersonnelClassHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass source, Domain.isa95.CommonObjectModels.HierarchyScope target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public PersonnelClassHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public PersonnelClassHierarchyScopeRelRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public PersonnelClassHierarchyScopeRelRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.HierarchyScope target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelClassHierarchyScopeRelRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(PersonnelClassHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(PersonnelClassHierarchyScopeRelRelationship? left, PersonnelClassHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PersonnelClassHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PersonnelClassHierarchyScopeRelRelationship? left, PersonnelClassHierarchyScopeRelRelationship? right)
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
            return Equals(other as PersonnelClassHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}