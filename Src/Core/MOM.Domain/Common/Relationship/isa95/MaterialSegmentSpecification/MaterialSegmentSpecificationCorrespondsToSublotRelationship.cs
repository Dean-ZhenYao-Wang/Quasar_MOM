namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationCorrespondsToSublotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification ,Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>, IEquatable<MaterialSegmentSpecificationCorrespondsToSublotRelationship>
    {
        public MaterialSegmentSpecificationCorrespondsToSublotRelationship()
        {
            Name = "correspondsToSublot";
        }

        public MaterialSegmentSpecificationCorrespondsToSublotRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationCorrespondsToSublotRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationCorrespondsToSublotRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationCorrespondsToSublotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationCorrespondsToSublotRelationship? left, MaterialSegmentSpecificationCorrespondsToSublotRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationCorrespondsToSublotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationCorrespondsToSublotRelationship? left, MaterialSegmentSpecificationCorrespondsToSublotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationCorrespondsToSublotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}