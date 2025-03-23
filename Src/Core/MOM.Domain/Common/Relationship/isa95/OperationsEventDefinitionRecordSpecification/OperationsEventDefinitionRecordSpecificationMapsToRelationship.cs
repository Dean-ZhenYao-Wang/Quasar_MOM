namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinitionRecordSpecification
{
    public class OperationsEventDefinitionRecordSpecificationMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassRecordSpecification>, IEquatable<OperationsEventDefinitionRecordSpecificationMapsToRelationship>
    {
        public OperationsEventDefinitionRecordSpecificationMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public OperationsEventDefinitionRecordSpecificationMapsToRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassRecordSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventDefinitionRecordSpecificationMapsToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinitionRecordSpecificationMapsToRelationship);
        }

        public bool Equals(OperationsEventDefinitionRecordSpecificationMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventDefinitionRecordSpecificationMapsToRelationship? left, OperationsEventDefinitionRecordSpecificationMapsToRelationship? right)
        {
            return EqualityComparer<OperationsEventDefinitionRecordSpecificationMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinitionRecordSpecificationMapsToRelationship? left, OperationsEventDefinitionRecordSpecificationMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventDefinitionRecordSpecificationMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}