namespace MOM.Domain.Common.Relationship.isa95.WorkAlertProperty
{
    public class WorkAlertPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinitionProperty>, IEquatable<WorkAlertPropertyMapsToRelationship>
    {
        public WorkAlertPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public WorkAlertPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertProperty source, Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkAlertPropertyMapsToRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkAlertPropertyMapsToRelationship);
        }

        public bool Equals(WorkAlertPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkAlertPropertyMapsToRelationship? left, WorkAlertPropertyMapsToRelationship? right)
        {
            return EqualityComparer<WorkAlertPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkAlertPropertyMapsToRelationship? left, WorkAlertPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkAlertPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}