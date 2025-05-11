namespace MOM.Domain.Common.Relationship.isa95.PropertyMeasurement
{
    public class PropertyMeasurementRecordsMeasurementOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty>, IEquatable<PropertyMeasurementRecordsMeasurementOfRelationship>
    {
        public PropertyMeasurementRecordsMeasurementOfRelationship()
        {
            Name = "recordsMeasurementOf";
        }

        public PropertyMeasurementRecordsMeasurementOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.PropertyMeasurement source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PropertyMeasurementRecordsMeasurementOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PropertyMeasurementRecordsMeasurementOfRelationship);
        }

        public bool Equals(PropertyMeasurementRecordsMeasurementOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PropertyMeasurementRecordsMeasurementOfRelationship? left, PropertyMeasurementRecordsMeasurementOfRelationship? right)
        {
            return EqualityComparer<PropertyMeasurementRecordsMeasurementOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PropertyMeasurementRecordsMeasurementOfRelationship? left, PropertyMeasurementRecordsMeasurementOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PropertyMeasurementRecordsMeasurementOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}