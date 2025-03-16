namespace MOM.Domain.Common.Relationship.isa95.FromResourceReference
{
    public class FromResourceReferenceCorrespondsToResourceClassRelationshipCollection : RelationshipCollection<FromResourceReferenceCorrespondsToResourceClassRelationship, Domain.isa95.CommonObjectModels.ResourceClass>
    {
        public FromResourceReferenceCorrespondsToResourceClassRelationshipCollection(IEnumerable<FromResourceReferenceCorrespondsToResourceClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<FromResourceReferenceCorrespondsToResourceClassRelationship>())
        {
        }
    }
}