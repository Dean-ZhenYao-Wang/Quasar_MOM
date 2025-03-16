namespace MOM.Domain.Common.Relationship.isa95.ToResourceReference
{
    public class ToResourceReferenceHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReferenceProperty>, IEquatable<ToResourceReferenceHasPropertiesOfRelationship>
    {
        public ToResourceReferenceHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public ToResourceReferenceHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReference source, Domain.isa95.CommonObjectModels.Part4.ResourceRelationship.ToResourceReferenceProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ToResourceReferenceHasPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ToResourceReferenceHasPropertiesOfRelationship);
        }

        public bool Equals(ToResourceReferenceHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ToResourceReferenceHasPropertiesOfRelationship? left, ToResourceReferenceHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<ToResourceReferenceHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ToResourceReferenceHasPropertiesOfRelationship? left, ToResourceReferenceHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ToResourceReferenceHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}