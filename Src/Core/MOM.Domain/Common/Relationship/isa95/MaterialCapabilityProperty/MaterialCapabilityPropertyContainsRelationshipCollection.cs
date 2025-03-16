namespace MOM.Domain.Common.Relationship.isa95.MaterialCapabilityProperty
{
    public class MaterialCapabilityPropertyContainsRelationshipCollection : RelationshipCollection<MaterialCapabilityPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapabilityProperty>
    {
        public MaterialCapabilityPropertyContainsRelationshipCollection(IEnumerable<MaterialCapabilityPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityPropertyContainsRelationship>())
        {
        }
    }
}