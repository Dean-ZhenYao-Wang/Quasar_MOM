using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.Enterprise
{
    public class EnterpriseSiteRelationship : Relationship<Domain.isa95.EquipmentHierarchy.Site>, IEquatable<EnterpriseSiteRelationship>
    {
        public EnterpriseSiteRelationship()
        {
            Name = "site";
        }

        [JsonIgnore]
        [ForeignKey(nameof(SourceId))]
        public virtual MOM.Domain.isa95.EquipmentHierarchy.Enterprise Source { get; set; }

        public EnterpriseSiteRelationship(Domain.isa95.EquipmentHierarchy.Enterprise source, Domain.isa95.EquipmentHierarchy.Site target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EnterpriseSiteRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EnterpriseSiteRelationship);
        }

        public bool Equals(EnterpriseSiteRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EnterpriseSiteRelationship? left, EnterpriseSiteRelationship? right)
        {
            return EqualityComparer<EnterpriseSiteRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EnterpriseSiteRelationship? left, EnterpriseSiteRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EnterpriseSiteRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}