namespace MOM.Domain.Common.Relationship.isa95.ToResourceReference
{
    public class ToResourceReferenceCorrespondsToResourceClassRelationshipCollection : RelationshipCollection<ToResourceReferenceCorrespondsToResourceClassRelationship, Domain.isa95.CommonObjectModels.ResourceClass>
    {
        public ToResourceReferenceCorrespondsToResourceClassRelationshipCollection(IEnumerable<ToResourceReferenceCorrespondsToResourceClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ToResourceReferenceCorrespondsToResourceClassRelationship>())
        {
        }
    }
}