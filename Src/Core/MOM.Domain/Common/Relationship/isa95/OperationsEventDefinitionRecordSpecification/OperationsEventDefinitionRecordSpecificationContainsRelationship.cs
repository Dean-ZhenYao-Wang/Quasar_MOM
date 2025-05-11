namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinitionRecordSpecification
{
    public class OperationsEventDefinitionRecordSpecificationContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification>, IEquatable<OperationsEventDefinitionRecordSpecificationContainsRelationship>
    {
        public OperationsEventDefinitionRecordSpecificationContainsRelationship()
        {
            Name = "contains";
        }

        public OperationsEventDefinitionRecordSpecificationContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventDefinitionRecordSpecificationContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinitionRecordSpecificationContainsRelationship);
        }

        public bool Equals(OperationsEventDefinitionRecordSpecificationContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventDefinitionRecordSpecificationContainsRelationship? left, OperationsEventDefinitionRecordSpecificationContainsRelationship? right)
        {
            return EqualityComparer<OperationsEventDefinitionRecordSpecificationContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinitionRecordSpecificationContainsRelationship? left, OperationsEventDefinitionRecordSpecificationContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventDefinitionRecordSpecificationContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}