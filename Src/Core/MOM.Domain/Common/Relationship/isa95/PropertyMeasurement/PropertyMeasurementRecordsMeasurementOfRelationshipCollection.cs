namespace MOM.Domain.Common.Relationship.isa95.PropertyMeasurement
{
    public class PropertyMeasurementRecordsMeasurementOfRelationshipCollection : RelationshipCollection<PropertyMeasurementRecordsMeasurementOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty>
    {
        public PropertyMeasurementRecordsMeasurementOfRelationshipCollection(IEnumerable<PropertyMeasurementRecordsMeasurementOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PropertyMeasurementRecordsMeasurementOfRelationship>())
        {
        }
    }
}