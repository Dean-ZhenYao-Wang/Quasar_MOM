namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecification
{
    public class PhysicalAssetSegmentSpecificationHasPropertiesOfRelationshipCollection : RelationshipCollection<PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecificationProperty>
    {
        public PhysicalAssetSegmentSpecificationHasPropertiesOfRelationshipCollection(IEnumerable<PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship>())
        {
        }
    }
}