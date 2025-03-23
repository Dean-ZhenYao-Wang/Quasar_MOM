namespace MOM.Domain.Common.Relationship.isa95.WorkRecord
{
    public class WorkRecordDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordSpecification>, IEquatable<WorkRecordDefinedByRelationship>
    {
        public WorkRecordDefinedByRelationship()
        {
            Name = "definedBy";
        }

        public WorkRecordDefinedByRelationship(Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecord source, Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkRecordDefinedByRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRecordDefinedByRelationship);
        }

        public bool Equals(WorkRecordDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkRecordDefinedByRelationship? left, WorkRecordDefinedByRelationship? right)
        {
            return EqualityComparer<WorkRecordDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRecordDefinedByRelationship? left, WorkRecordDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkRecordDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}