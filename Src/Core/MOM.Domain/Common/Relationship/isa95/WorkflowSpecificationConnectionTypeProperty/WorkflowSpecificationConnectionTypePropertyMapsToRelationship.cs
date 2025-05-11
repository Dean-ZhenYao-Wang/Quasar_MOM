namespace MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionTypeProperty
{
    public class WorkflowSpecificationConnectionTypePropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionProperty>, IEquatable<WorkflowSpecificationConnectionTypePropertyMapsToRelationship>
    {
        public WorkflowSpecificationConnectionTypePropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public WorkflowSpecificationConnectionTypePropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionTypeProperty source, Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification.WorkflowSpecificationConnectionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkflowSpecificationConnectionTypePropertyMapsToRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionTypePropertyMapsToRelationship);
        }

        public bool Equals(WorkflowSpecificationConnectionTypePropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkflowSpecificationConnectionTypePropertyMapsToRelationship? left, WorkflowSpecificationConnectionTypePropertyMapsToRelationship? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionTypePropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionTypePropertyMapsToRelationship? left, WorkflowSpecificationConnectionTypePropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkflowSpecificationConnectionTypePropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}