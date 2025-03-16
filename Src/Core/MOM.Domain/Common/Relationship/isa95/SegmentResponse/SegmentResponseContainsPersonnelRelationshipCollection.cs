namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseContainsPersonnelRelationshipCollection : RelationshipCollection<SegmentResponseContainsPersonnelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual>
    {
        public SegmentResponseContainsPersonnelRelationshipCollection(IEnumerable<SegmentResponseContainsPersonnelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentResponseContainsPersonnelRelationship>())
        {
        }
    }
}