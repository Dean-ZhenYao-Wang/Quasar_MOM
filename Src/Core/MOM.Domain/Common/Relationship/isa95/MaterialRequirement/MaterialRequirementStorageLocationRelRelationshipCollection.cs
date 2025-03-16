namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementStorageLocationRelRelationshipCollection : RelationshipCollection<MaterialRequirementStorageLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public MaterialRequirementStorageLocationRelRelationshipCollection(IEnumerable<MaterialRequirementStorageLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementStorageLocationRelRelationship>())
        {
        }
    }
}