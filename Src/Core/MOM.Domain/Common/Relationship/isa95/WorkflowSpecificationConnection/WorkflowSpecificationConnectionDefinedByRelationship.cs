namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnection
{
    public class WorkflowSpecificationConnectionDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionType>, IEquatable<WorkflowSpecificationConnectionDefinedByRelationship>
    {
        public WorkflowSpecificationConnectionDefinedByRelationship()
        {
            Name = "definedBy";
        }

        public WorkflowSpecificationConnectionDefinedByRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnection source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionType target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationConnectionDefinedByRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionDefinedByRelationship);
        }

        public bool Equals(WorkflowSpecificationConnectionDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationConnectionDefinedByRelationship? left, WorkflowSpecificationConnectionDefinedByRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionDefinedByRelationship? left, WorkflowSpecificationConnectionDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationConnectionDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}