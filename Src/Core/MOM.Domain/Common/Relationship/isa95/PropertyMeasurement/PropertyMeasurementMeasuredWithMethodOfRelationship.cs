namespace MOM.Domain.Common.Relationship.isa95.PropertyMeasurement
{
    public class PropertyMeasurementMeasuredWithMethodOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition>, IEquatable<PropertyMeasurementMeasuredWithMethodOfRelationship>
    {
        public PropertyMeasurementMeasuredWithMethodOfRelationship()
        {
            Name = "measuredWithMethodOf";
        }

        public PropertyMeasurementMeasuredWithMethodOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.PropertyMeasurement source, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PropertyMeasurementMeasuredWithMethodOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PropertyMeasurementMeasuredWithMethodOfRelationship);
        }

        public bool Equals(PropertyMeasurementMeasuredWithMethodOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PropertyMeasurementMeasuredWithMethodOfRelationship? left, PropertyMeasurementMeasuredWithMethodOfRelationship? right)
        {
            return EqualityComparer<PropertyMeasurementMeasuredWithMethodOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PropertyMeasurementMeasuredWithMethodOfRelationship? left, PropertyMeasurementMeasuredWithMethodOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PropertyMeasurementMeasuredWithMethodOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}