namespace MOM.Domain.Common.Relationship.isa95.WorkRecordSpecification
{
    public class WorkRecordSpecificationContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordSpecification>, IEquatable<WorkRecordSpecificationContainsRelationship>
    {
        public WorkRecordSpecificationContainsRelationship()
        {
            Name = "contains";
        }

        public WorkRecordSpecificationContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordSpecification source, Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkRecordSpecificationContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRecordSpecificationContainsRelationship);
        }

        public bool Equals(WorkRecordSpecificationContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkRecordSpecificationContainsRelationship? left, WorkRecordSpecificationContainsRelationship? right)
        {
            return EqualityComparer<WorkRecordSpecificationContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRecordSpecificationContainsRelationship? left, WorkRecordSpecificationContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkRecordSpecificationContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}