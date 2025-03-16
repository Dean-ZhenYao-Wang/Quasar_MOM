namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationCorrespondsToClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>, IEquatable<MaterialSegmentSpecificationCorrespondsToClassRelationship>
    {
        public MaterialSegmentSpecificationCorrespondsToClassRelationship()
        {
            Name = "correspondsToClass";
        }

        public MaterialSegmentSpecificationCorrespondsToClassRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationCorrespondsToClassRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationCorrespondsToClassRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationCorrespondsToClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationCorrespondsToClassRelationship? left, MaterialSegmentSpecificationCorrespondsToClassRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationCorrespondsToClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationCorrespondsToClassRelationship? left, MaterialSegmentSpecificationCorrespondsToClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationCorrespondsToClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}