namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClass
{
    public class OperationsEventClassHasRecordSpecificationOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassRecordSpecification>, IEquatable<OperationsEventClassHasRecordSpecificationOfRelationship>
    {
        public OperationsEventClassHasRecordSpecificationOfRelationship()
        {
            Name = "hasRecordSpecificationOf";
        }

        public OperationsEventClassHasRecordSpecificationOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassRecordSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventClassHasRecordSpecificationOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventClassHasRecordSpecificationOfRelationship);
        }

        public bool Equals(OperationsEventClassHasRecordSpecificationOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventClassHasRecordSpecificationOfRelationship? left, OperationsEventClassHasRecordSpecificationOfRelationship? right)
        {
            return EqualityComparer<OperationsEventClassHasRecordSpecificationOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventClassHasRecordSpecificationOfRelationship? left, OperationsEventClassHasRecordSpecificationOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventClassHasRecordSpecificationOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}