namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentContainsPersonnelRelationshipCollection : RelationshipCollection<OperationsSegmentContainsPersonnelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification>
    {
        public OperationsSegmentContainsPersonnelRelationshipCollection(IEnumerable<OperationsSegmentContainsPersonnelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentContainsPersonnelRelationship>())
        {
        }
    }
}