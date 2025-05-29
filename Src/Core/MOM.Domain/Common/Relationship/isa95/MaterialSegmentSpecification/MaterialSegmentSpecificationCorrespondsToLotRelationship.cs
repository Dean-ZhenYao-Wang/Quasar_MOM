namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationCorrespondsToLotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification ,Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>, IEquatable<MaterialSegmentSpecificationCorrespondsToLotRelationship>
    {
        public MaterialSegmentSpecificationCorrespondsToLotRelationship()
        {
            Name = "correspondsToLot";
        }

        public MaterialSegmentSpecificationCorrespondsToLotRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationCorrespondsToLotRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationCorrespondsToLotRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationCorrespondsToLotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationCorrespondsToLotRelationship? left, MaterialSegmentSpecificationCorrespondsToLotRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationCorrespondsToLotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationCorrespondsToLotRelationship? left, MaterialSegmentSpecificationCorrespondsToLotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationCorrespondsToLotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}