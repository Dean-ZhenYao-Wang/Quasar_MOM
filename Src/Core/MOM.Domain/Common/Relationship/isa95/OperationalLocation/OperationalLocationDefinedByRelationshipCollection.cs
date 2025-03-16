namespace MOM.Domain.Common.Relationship.isa95.OperationalLocation
{
    public class OperationalLocationDefinedByRelationshipCollection : RelationshipCollection<OperationalLocationDefinedByRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass>
    {
        public OperationalLocationDefinedByRelationshipCollection(IEnumerable<OperationalLocationDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationalLocationDefinedByRelationship>())
        {
        }
    }
}