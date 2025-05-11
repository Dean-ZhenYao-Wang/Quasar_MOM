namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty>, IEquatable<MaterialSegmentSpecificationHasPropertiesOfRelationship>
    {
        public MaterialSegmentSpecificationHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public MaterialSegmentSpecificationHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationHasPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationHasPropertiesOfRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationHasPropertiesOfRelationship? left, MaterialSegmentSpecificationHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationHasPropertiesOfRelationship? left, MaterialSegmentSpecificationHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}