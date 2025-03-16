namespace MOM.Domain.Common.Relationship.isa95.WorkMaster
{
    public class WorkMasterIncludesPropertiesOfRelationshipCollection : RelationshipCollection<WorkMasterIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>
    {
        public WorkMasterIncludesPropertiesOfRelationshipCollection(IEnumerable<WorkMasterIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterIncludesPropertiesOfRelationship>())
        {
        }
    }
}