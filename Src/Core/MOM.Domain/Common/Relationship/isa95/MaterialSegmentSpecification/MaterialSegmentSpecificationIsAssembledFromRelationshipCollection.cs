namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationIsAssembledFromRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification>
    {
        public MaterialSegmentSpecificationIsAssembledFromRelationshipCollection(IEnumerable<MaterialSegmentSpecificationIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationIsAssembledFromRelationship>())
        {
        }
    }
}