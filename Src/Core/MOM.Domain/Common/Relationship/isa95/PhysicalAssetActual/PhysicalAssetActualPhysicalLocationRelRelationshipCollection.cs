namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual
{
    public class PhysicalAssetActualPhysicalLocationRelRelationshipCollection : RelationshipCollection<PhysicalAssetActualPhysicalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PhysicalAssetActualPhysicalLocationRelRelationshipCollection(IEnumerable<PhysicalAssetActualPhysicalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetActualPhysicalLocationRelRelationship>())
        {
        }
    }
}