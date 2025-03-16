namespace MOM.Domain.Common.Relationship.isa95.ToResourceReference
{
    public class ToResourceReferenceCorrespondsToResourceRelationship : Relationship<Domain.isa95.CommonObjectModels.Resource>, IEquatable<ToResourceReferenceCorrespondsToResourceRelationship>
    {
        public ToResourceReferenceCorrespondsToResourceRelationship()
        {
            Name = "correspondsToResource";
        }

        public ToResourceReferenceCorrespondsToResourceRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReference source, Domain.isa95.CommonObjectModels.Resource target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ToResourceReferenceCorrespondsToResourceRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ToResourceReferenceCorrespondsToResourceRelationship);
        }

        public bool Equals(ToResourceReferenceCorrespondsToResourceRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ToResourceReferenceCorrespondsToResourceRelationship? left, ToResourceReferenceCorrespondsToResourceRelationship? right)
        {
            return EqualityComparer<ToResourceReferenceCorrespondsToResourceRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ToResourceReferenceCorrespondsToResourceRelationship? left, ToResourceReferenceCorrespondsToResourceRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ToResourceReferenceCorrespondsToResourceRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}