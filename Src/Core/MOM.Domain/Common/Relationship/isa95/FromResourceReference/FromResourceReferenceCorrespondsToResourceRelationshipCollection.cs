namespace MOM.Domain.Common.Relationship.isa95.FromResourceReference
{
    public class FromResourceReferenceCorrespondsToResourceRelationshipCollection : RelationshipCollection<FromResourceReferenceCorrespondsToResourceRelationship, Domain.isa95.CommonObjectModels.Resource>
    {
        public FromResourceReferenceCorrespondsToResourceRelationshipCollection(IEnumerable<FromResourceReferenceCorrespondsToResourceRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<FromResourceReferenceCorrespondsToResourceRelationship>())
        {
        }
    }
}