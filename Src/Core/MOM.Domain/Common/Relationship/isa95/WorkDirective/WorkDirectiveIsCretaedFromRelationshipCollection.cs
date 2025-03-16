namespace MOM.Domain.Common.Relationship.isa95.WorkDirective
{
    public class WorkDirectiveIsCretaedFromRelationshipCollection : RelationshipCollection<WorkDirectiveIsCretaedFromRelationship, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>
    {
        public WorkDirectiveIsCretaedFromRelationshipCollection(IEnumerable<WorkDirectiveIsCretaedFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkDirectiveIsCretaedFromRelationship>())
        {
        }
    }
}