namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClass
{
    public class OperationalLocationClassHasPropertiesOfRelationshipCollection : RelationshipCollection<OperationalLocationClassHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClassProperty>
    {
        public OperationalLocationClassHasPropertiesOfRelationshipCollection(IEnumerable<OperationalLocationClassHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationalLocationClassHasPropertiesOfRelationship>())
        {
        }
    }
}