namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityIsAssembledFromRelationshipCollection : RelationshipCollection<MaterialCapabilityIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability>
    {
        public MaterialCapabilityIsAssembledFromRelationshipCollection(IEnumerable<MaterialCapabilityIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityIsAssembledFromRelationship>())
        {
        }
    }
}