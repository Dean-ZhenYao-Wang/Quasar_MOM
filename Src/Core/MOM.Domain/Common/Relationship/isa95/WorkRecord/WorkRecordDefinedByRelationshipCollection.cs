namespace MOM.Domain.Common.Relationship.isa95.WorkRecord
{
    public class WorkRecordDefinedByRelationshipCollection : RelationshipCollection<WorkRecordDefinedByRelationship, Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordSpecification>
    {
        public WorkRecordDefinedByRelationshipCollection(IEnumerable<WorkRecordDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRecordDefinedByRelationship>())
        {
        }
    }
}