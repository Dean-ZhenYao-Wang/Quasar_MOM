namespace MOM.Domain.Common.Relationship.isa95.WorkMaster
{
    public class WorkMasterHasARelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification>, IEquatable<WorkMasterHasARelationship>
    {
        public WorkMasterHasARelationship()
        {
            Name = "hasA";
        }

        public WorkMasterHasARelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkMasterHasARelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterHasARelationship);
        }

        public bool Equals(WorkMasterHasARelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkMasterHasARelationship? left, WorkMasterHasARelationship? right)
        {
            return EqualityComparer<WorkMasterHasARelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterHasARelationship? left, WorkMasterHasARelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkMasterHasARelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}