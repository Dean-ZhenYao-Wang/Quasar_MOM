namespace MOM.Domain.Common.Relationship.isa95.WorkAlert
{
    public class WorkAlertDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinition>, IEquatable<WorkAlertDefinedByRelationship>
    {
        public WorkAlertDefinedByRelationship()
        {
            Name = "definedBy";
        }

        public WorkAlertDefinedByRelationship(Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlert source, Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkAlertDefinedByRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkAlertDefinedByRelationship);
        }

        public bool Equals(WorkAlertDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkAlertDefinedByRelationship? left, WorkAlertDefinedByRelationship? right)
        {
            return EqualityComparer<WorkAlertDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkAlertDefinedByRelationship? left, WorkAlertDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkAlertDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}