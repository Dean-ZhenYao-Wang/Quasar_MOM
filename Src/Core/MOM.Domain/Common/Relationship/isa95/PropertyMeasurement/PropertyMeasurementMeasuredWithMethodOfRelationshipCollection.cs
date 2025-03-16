namespace MOM.Domain.Common.Relationship.isa95.PropertyMeasurement
{
    public class PropertyMeasurementMeasuredWithMethodOfRelationshipCollection : RelationshipCollection<PropertyMeasurementMeasuredWithMethodOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition>
    {
        public PropertyMeasurementMeasuredWithMethodOfRelationshipCollection(IEnumerable<PropertyMeasurementMeasuredWithMethodOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PropertyMeasurementMeasuredWithMethodOfRelationship>())
        {
        }
    }
}