namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClassRecordSpecification
{
    public class OperationsEventClassRecordSpecificationContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification>, IEquatable<OperationsEventClassRecordSpecificationContainsRelationship>
    {
        public OperationsEventClassRecordSpecificationContainsRelationship()
        {
            Name = "contains";
        }

        public OperationsEventClassRecordSpecificationContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassRecordSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventClassRecordSpecificationContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventClassRecordSpecificationContainsRelationship);
        }

        public bool Equals(OperationsEventClassRecordSpecificationContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventClassRecordSpecificationContainsRelationship? left, OperationsEventClassRecordSpecificationContainsRelationship? right)
        {
            return EqualityComparer<OperationsEventClassRecordSpecificationContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventClassRecordSpecificationContainsRelationship? left, OperationsEventClassRecordSpecificationContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventClassRecordSpecificationContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}