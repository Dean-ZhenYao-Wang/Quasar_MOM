namespace MOM.Domain.Common.Relationship.isa95.WorkRecordSpecification
{
    public class WorkRecordSpecificationContainsRelationshipCollection : RelationshipCollection<WorkRecordSpecificationContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordSpecification>
    {
        public WorkRecordSpecificationContainsRelationshipCollection(IEnumerable<WorkRecordSpecificationContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRecordSpecificationContainsRelationship>())
        {
        }
    }
}