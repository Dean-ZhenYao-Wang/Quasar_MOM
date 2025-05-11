namespace MOM.Domain.Common.Relationship.isa95.FromResourceReference
{
    public class FromResourceReferenceCorrespondsToResourceClassRelationship : Relationship<Domain.isa95.CommonObjectModels.ResourceClass>, IEquatable<FromResourceReferenceCorrespondsToResourceClassRelationship>
    {
        public FromResourceReferenceCorrespondsToResourceClassRelationship()
        {
            Name = "correspondsToResourceClass";
        }

        public FromResourceReferenceCorrespondsToResourceClassRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReference source, Domain.isa95.CommonObjectModels.ResourceClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public FromResourceReferenceCorrespondsToResourceClassRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as FromResourceReferenceCorrespondsToResourceClassRelationship);
        }

        public bool Equals(FromResourceReferenceCorrespondsToResourceClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(FromResourceReferenceCorrespondsToResourceClassRelationship? left, FromResourceReferenceCorrespondsToResourceClassRelationship? right)
        {
            return EqualityComparer<FromResourceReferenceCorrespondsToResourceClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(FromResourceReferenceCorrespondsToResourceClassRelationship? left, FromResourceReferenceCorrespondsToResourceClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as FromResourceReferenceCorrespondsToResourceClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}