namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionProperty
{
    public class WorkflowSpecificationConnectionPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionTypeProperty>, IEquatable<WorkflowSpecificationConnectionPropertyMapsToRelationship>
    {
        public WorkflowSpecificationConnectionPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public WorkflowSpecificationConnectionPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionProperty source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionTypeProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationConnectionPropertyMapsToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionPropertyMapsToRelationship);
        }

        public bool Equals(WorkflowSpecificationConnectionPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationConnectionPropertyMapsToRelationship? left, WorkflowSpecificationConnectionPropertyMapsToRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionPropertyMapsToRelationship? left, WorkflowSpecificationConnectionPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationConnectionPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}