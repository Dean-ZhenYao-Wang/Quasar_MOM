namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationHasPropertiesOfRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty>
    {
        public MaterialSegmentSpecificationHasPropertiesOfRelationshipCollection(IEnumerable<MaterialSegmentSpecificationHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationHasPropertiesOfRelationship>())
        {
        }
    }
}