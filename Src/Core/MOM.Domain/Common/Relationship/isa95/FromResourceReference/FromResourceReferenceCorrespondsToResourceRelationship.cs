namespace MOM.Domain.Common.Relationship.isa95.FromResourceReference
{
    public class FromResourceReferenceCorrespondsToResourceRelationship : Relationship<Domain.isa95.CommonObjectModels.Resource>, IEquatable<FromResourceReferenceCorrespondsToResourceRelationship>
    {
        public FromResourceReferenceCorrespondsToResourceRelationship()
        {
            Name = "correspondsToResource";
        }

        public FromResourceReferenceCorrespondsToResourceRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReference source, Domain.isa95.CommonObjectModels.Resource target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public FromResourceReferenceCorrespondsToResourceRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as FromResourceReferenceCorrespondsToResourceRelationship);
        }

        public bool Equals(FromResourceReferenceCorrespondsToResourceRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(FromResourceReferenceCorrespondsToResourceRelationship? left, FromResourceReferenceCorrespondsToResourceRelationship? right)
        {
            return EqualityComparer<FromResourceReferenceCorrespondsToResourceRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(FromResourceReferenceCorrespondsToResourceRelationship? left, FromResourceReferenceCorrespondsToResourceRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as FromResourceReferenceCorrespondsToResourceRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}