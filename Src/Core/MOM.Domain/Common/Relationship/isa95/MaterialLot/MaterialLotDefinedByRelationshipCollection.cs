namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotDefinedByRelationshipCollection : RelationshipCollection<MaterialLotDefinedByRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>
    {
        public MaterialLotDefinedByRelationshipCollection(IEnumerable<MaterialLotDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialLotDefinedByRelationship>())
        {
        }
    }
}