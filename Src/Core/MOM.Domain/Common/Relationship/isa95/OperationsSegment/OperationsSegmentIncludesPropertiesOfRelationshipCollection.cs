namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentIncludesPropertiesOfRelationshipCollection : RelationshipCollection<OperationsSegmentIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public OperationsSegmentIncludesPropertiesOfRelationshipCollection(IEnumerable<OperationsSegmentIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentIncludesPropertiesOfRelationship>())
        {
        }
    }
}