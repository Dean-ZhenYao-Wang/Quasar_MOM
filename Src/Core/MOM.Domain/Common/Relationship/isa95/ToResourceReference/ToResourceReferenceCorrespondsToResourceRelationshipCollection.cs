namespace MOM.Domain.Common.Relationship.isa95.ToResourceReference
{
    public class ToResourceReferenceCorrespondsToResourceRelationshipCollection : RelationshipCollection<ToResourceReferenceCorrespondsToResourceRelationship, Domain.isa95.CommonObjectModels.Resource>
    {
        public ToResourceReferenceCorrespondsToResourceRelationshipCollection(IEnumerable<ToResourceReferenceCorrespondsToResourceRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ToResourceReferenceCorrespondsToResourceRelationship>())
        {
        }
    }
}