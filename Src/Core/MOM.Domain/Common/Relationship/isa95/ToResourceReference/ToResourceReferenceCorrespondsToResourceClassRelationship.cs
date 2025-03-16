namespace MOM.Domain.Common.Relationship.isa95.ToResourceReference
{
    public class ToResourceReferenceCorrespondsToResourceClassRelationship : Relationship<Domain.isa95.CommonObjectModels.ResourceClass>, IEquatable<ToResourceReferenceCorrespondsToResourceClassRelationship>
    {
        public ToResourceReferenceCorrespondsToResourceClassRelationship()
        {
            Name = "correspondsToResourceClass";
        }

        public ToResourceReferenceCorrespondsToResourceClassRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReference source, Domain.isa95.CommonObjectModels.ResourceClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ToResourceReferenceCorrespondsToResourceClassRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ToResourceReferenceCorrespondsToResourceClassRelationship);
        }

        public bool Equals(ToResourceReferenceCorrespondsToResourceClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ToResourceReferenceCorrespondsToResourceClassRelationship? left, ToResourceReferenceCorrespondsToResourceClassRelationship? right)
        {
            return EqualityComparer<ToResourceReferenceCorrespondsToResourceClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ToResourceReferenceCorrespondsToResourceClassRelationship? left, ToResourceReferenceCorrespondsToResourceClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ToResourceReferenceCorrespondsToResourceClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}