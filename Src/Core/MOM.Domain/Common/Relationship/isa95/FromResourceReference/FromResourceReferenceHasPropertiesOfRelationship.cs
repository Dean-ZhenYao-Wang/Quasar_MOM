namespace MOM.Domain.Common.Relationship.isa95.FromResourceReference
{
    public class FromResourceReferenceHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReferenceProperty>, IEquatable<FromResourceReferenceHasPropertiesOfRelationship>
    {
        public FromResourceReferenceHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public FromResourceReferenceHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReference source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.FromResourceReferenceProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public FromResourceReferenceHasPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as FromResourceReferenceHasPropertiesOfRelationship);
        }

        public bool Equals(FromResourceReferenceHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(FromResourceReferenceHasPropertiesOfRelationship? left, FromResourceReferenceHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<FromResourceReferenceHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(FromResourceReferenceHasPropertiesOfRelationship? left, FromResourceReferenceHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as FromResourceReferenceHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}