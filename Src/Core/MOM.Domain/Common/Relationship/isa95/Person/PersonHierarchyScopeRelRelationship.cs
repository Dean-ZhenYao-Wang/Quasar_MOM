using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.Person
{
    public class PersonHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PersonHierarchyScopeRelRelationship>
    {
        [JsonIgnore]
        [ForeignKey(nameof(SourceId))]
        public virtual Domain.isa95.CommonObjectModels.Part2.Personnel.Person Source { get; set; }
        public PersonHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public PersonHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.Person source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonHierarchyScopeRelRelationship);
        }

        public bool Equals(PersonHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonHierarchyScopeRelRelationship? left, PersonHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PersonHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonHierarchyScopeRelRelationship? left, PersonHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}