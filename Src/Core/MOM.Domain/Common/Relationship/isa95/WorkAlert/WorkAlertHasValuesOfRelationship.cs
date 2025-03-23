namespace MOM.Domain.Common.Relationship.isa95.WorkAlert
{
    public class WorkAlertHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertProperty>, IEquatable<WorkAlertHasValuesOfRelationship>
    {
        public WorkAlertHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public WorkAlertHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlert source, Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkAlertHasValuesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkAlertHasValuesOfRelationship);
        }

        public bool Equals(WorkAlertHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkAlertHasValuesOfRelationship? left, WorkAlertHasValuesOfRelationship? right)
        {
            return EqualityComparer<WorkAlertHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkAlertHasValuesOfRelationship? left, WorkAlertHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkAlertHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}