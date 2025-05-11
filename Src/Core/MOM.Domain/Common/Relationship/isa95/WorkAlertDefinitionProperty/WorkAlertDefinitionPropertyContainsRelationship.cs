namespace MOM.Domain.Common.Relationship.isa95.WorkAlertDefinitionProperty
{
    public class WorkAlertDefinitionPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinitionProperty>, IEquatable<WorkAlertDefinitionPropertyContainsRelationship>
    {
        public WorkAlertDefinitionPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public WorkAlertDefinitionPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinitionProperty source, Domain.isa95.CommonObjectModels.Part4.WorkAlert.WorkAlertDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkAlertDefinitionPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkAlertDefinitionPropertyContainsRelationship);
        }

        public bool Equals(WorkAlertDefinitionPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkAlertDefinitionPropertyContainsRelationship? left, WorkAlertDefinitionPropertyContainsRelationship? right)
        {
            return EqualityComparer<WorkAlertDefinitionPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkAlertDefinitionPropertyContainsRelationship? left, WorkAlertDefinitionPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkAlertDefinitionPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}