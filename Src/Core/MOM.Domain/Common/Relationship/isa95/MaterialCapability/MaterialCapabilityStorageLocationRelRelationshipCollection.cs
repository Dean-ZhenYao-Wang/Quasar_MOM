namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityStorageLocationRelRelationshipCollection : RelationshipCollection<MaterialCapabilityStorageLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public MaterialCapabilityStorageLocationRelRelationshipCollection(IEnumerable<MaterialCapabilityStorageLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityStorageLocationRelRelationship>())
        {
        }
    }
}