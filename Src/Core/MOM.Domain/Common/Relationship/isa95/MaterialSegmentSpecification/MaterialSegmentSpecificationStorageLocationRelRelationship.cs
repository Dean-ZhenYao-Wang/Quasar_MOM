namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationStorageLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<MaterialSegmentSpecificationStorageLocationRelRelationship>
    {
        public MaterialSegmentSpecificationStorageLocationRelRelationship()
        {
            Name = "storageLocationRel";
        }

        public MaterialSegmentSpecificationStorageLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationStorageLocationRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationStorageLocationRelRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationStorageLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationStorageLocationRelRelationship? left, MaterialSegmentSpecificationStorageLocationRelRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationStorageLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationStorageLocationRelRelationship? left, MaterialSegmentSpecificationStorageLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationStorageLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}