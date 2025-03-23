namespace MOM.Domain.Common.Relationship.isa95.WorkRecord
{
    public class WorkRecordContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecord>, IEquatable<WorkRecordContainsRelationship>
    {
        public WorkRecordContainsRelationship()
        {
            Name = "contains";
        }

        public WorkRecordContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecord source, Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecord target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkRecordContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRecordContainsRelationship);
        }

        public bool Equals(WorkRecordContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkRecordContainsRelationship? left, WorkRecordContainsRelationship? right)
        {
            return EqualityComparer<WorkRecordContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRecordContainsRelationship? left, WorkRecordContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkRecordContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}