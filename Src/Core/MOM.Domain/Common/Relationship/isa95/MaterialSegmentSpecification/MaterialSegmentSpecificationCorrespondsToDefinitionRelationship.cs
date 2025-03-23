namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationCorrespondsToDefinitionRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>, IEquatable<MaterialSegmentSpecificationCorrespondsToDefinitionRelationship>
    {
        public MaterialSegmentSpecificationCorrespondsToDefinitionRelationship()
        {
            Name = "correspondsToDefinition";
        }

        public MaterialSegmentSpecificationCorrespondsToDefinitionRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSegmentSpecificationCorrespondsToDefinitionRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSegmentSpecificationCorrespondsToDefinitionRelationship);
        }

        public bool Equals(MaterialSegmentSpecificationCorrespondsToDefinitionRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSegmentSpecificationCorrespondsToDefinitionRelationship? left, MaterialSegmentSpecificationCorrespondsToDefinitionRelationship? right)
        {
            return EqualityComparer<MaterialSegmentSpecificationCorrespondsToDefinitionRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSegmentSpecificationCorrespondsToDefinitionRelationship? left, MaterialSegmentSpecificationCorrespondsToDefinitionRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSegmentSpecificationCorrespondsToDefinitionRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}