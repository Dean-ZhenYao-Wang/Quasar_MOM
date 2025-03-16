namespace MOM.Domain.Common.Relationship.isa95.Site
{
    public partial class SiteAreaRelationship : Relationship<Domain.isa95.EquipmentHierarchy.Area>, IEquatable<SiteAreaRelationship>
    {
        public SiteAreaRelationship()
        {
            Name = "area";
        }

        public SiteAreaRelationship(Domain.isa95.EquipmentHierarchy.Site source, Domain.isa95.EquipmentHierarchy.Area target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SiteAreaRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SiteAreaRelationship);
        }

        public bool Equals(SiteAreaRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SiteAreaRelationship? left, SiteAreaRelationship? right)
        {
            return EqualityComparer<SiteAreaRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SiteAreaRelationship? left, SiteAreaRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SiteAreaRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}