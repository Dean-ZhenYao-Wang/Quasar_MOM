namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNodeProperty
{
    public class WorkflowSpecificationNodePropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty>, IEquatable<WorkflowSpecificationNodePropertyMapsToRelationship>
    {
        public WorkflowSpecificationNodePropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public WorkflowSpecificationNodePropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeProperty source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationNodeTypeProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationNodePropertyMapsToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodePropertyMapsToRelationship);
        }

        public bool Equals(WorkflowSpecificationNodePropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationNodePropertyMapsToRelationship? left, WorkflowSpecificationNodePropertyMapsToRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationNodePropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodePropertyMapsToRelationship? left, WorkflowSpecificationNodePropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationNodePropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}