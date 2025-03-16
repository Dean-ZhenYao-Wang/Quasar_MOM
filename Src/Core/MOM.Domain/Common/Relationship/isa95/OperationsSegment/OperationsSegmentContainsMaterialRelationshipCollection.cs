namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentContainsMaterialRelationshipCollection : RelationshipCollection<OperationsSegmentContainsMaterialRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification>
    {
        public OperationsSegmentContainsMaterialRelationshipCollection(IEnumerable<OperationsSegmentContainsMaterialRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentContainsMaterialRelationship>())
        {
        }
    }
}