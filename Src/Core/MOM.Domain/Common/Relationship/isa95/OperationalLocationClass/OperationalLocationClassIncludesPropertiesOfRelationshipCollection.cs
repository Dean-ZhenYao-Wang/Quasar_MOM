namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClass
{
    public class OperationalLocationClassIncludesPropertiesOfRelationshipCollection : RelationshipCollection<OperationalLocationClassIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass>
    {
        public OperationalLocationClassIncludesPropertiesOfRelationshipCollection(IEnumerable<OperationalLocationClassIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationalLocationClassIncludesPropertiesOfRelationship>())
        {
        }
    }
}