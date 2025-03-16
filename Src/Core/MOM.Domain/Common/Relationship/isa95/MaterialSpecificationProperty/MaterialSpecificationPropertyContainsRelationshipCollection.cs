namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecificationProperty
{
    public class MaterialSpecificationPropertyContainsRelationshipCollection : RelationshipCollection<MaterialSpecificationPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty>
    {
        public MaterialSpecificationPropertyContainsRelationshipCollection(IEnumerable<MaterialSpecificationPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationPropertyContainsRelationship>())
        {
        }
    }
}