using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.HierarchyScope
{
    public class HierarchyScopeContainsRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.HierarchyScope, MOM.Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<HierarchyScopeContainsRelationship>
    {
        public HierarchyScopeContainsRelationship():base()
        {
            Name = "contains";
        }

        public HierarchyScopeContainsRelationship(Domain.isa95.CommonObjectModels.HierarchyScope source, Domain.isa95.CommonObjectModels.HierarchyScope target) : base(source, target)
        {
        }

        public HierarchyScopeContainsRelationship(Guid? sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        public HierarchyScopeContainsRelationship(Guid? sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        public HierarchyScopeContainsRelationship(Guid? sourceId, Domain.isa95.CommonObjectModels.HierarchyScope target, int depth) : base(sourceId, target, depth)
        {
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
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as HierarchyScopeContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}