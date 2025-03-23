namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationIsAssembledFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification>, IEquatable<MaterialSegmentSpecificationIsAssembledFromRelationship>
    {
        public MaterialSegmentSpecificationIsAssembledFromRelationship()
        {
            Name = "IsAssembledFrom";
        }

        public MaterialSegmentSpecificationIsAssembledFromRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationIsAssembledFromRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationIsAssembledFromRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationIsAssembledFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationIsAssembledFromRelationship? left, MaterialSegmentSpecificationIsAssembledFromRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationIsAssembledFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationIsAssembledFromRelationship? left, MaterialSegmentSpecificationIsAssembledFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationIsAssembledFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}