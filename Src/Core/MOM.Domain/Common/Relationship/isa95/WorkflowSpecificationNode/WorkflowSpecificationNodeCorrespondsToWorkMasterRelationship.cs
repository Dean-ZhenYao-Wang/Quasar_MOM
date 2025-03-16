namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNode
{
    public class WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>, IEquatable<WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship>
    {
        public WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship()
        {
            Name = "correspondsToWorkMaster";
        }

        public WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNode source, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship);
        }

        public bool Equals(WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship? left, WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship? left, WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationNodeCorrespondsToWorkMasterRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}