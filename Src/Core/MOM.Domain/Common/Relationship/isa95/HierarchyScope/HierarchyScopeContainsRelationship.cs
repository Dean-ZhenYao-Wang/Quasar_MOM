using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.HierarchyScope
{
    public class HierarchyScopeContainsRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<HierarchyScopeContainsRelationship>
    {
        public HierarchyScopeContainsRelationship()
        {
            Name = "contains";
        }

        [JsonIgnore]
        [ForeignKey(nameof(SourceId))]
        public virtual MOM.Domain.isa95.CommonObjectModels.HierarchyScope Source { get; set; }

        public HierarchyScopeContainsRelationship(MOM.Domain.isa95.CommonObjectModels.HierarchyScope source, MOM.Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public HierarchyScopeContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as HierarchyScopeContainsRelationship);
        }

        public bool Equals(HierarchyScopeContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(HierarchyScopeContainsRelationship? left, HierarchyScopeContainsRelationship? right)
        {
            return EqualityComparer<HierarchyScopeContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(HierarchyScopeContainsRelationship? left, HierarchyScopeContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as HierarchyScopeContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}