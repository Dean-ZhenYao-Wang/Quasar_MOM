namespace MOM.Domain.Common.Relationship.isa95.WorkDirective
{
    public class WorkDirectiveContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDirective>, IEquatable<WorkDirectiveContainsRelationship>
    {
        public WorkDirectiveContainsRelationship()
        {
            Name = "contains";
        }

        public WorkDirectiveContainsRelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDirective source, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDirective target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkDirectiveContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkDirectiveContainsRelationship);
        }

        public bool Equals(WorkDirectiveContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkDirectiveContainsRelationship? left, WorkDirectiveContainsRelationship? right)
        {
            return EqualityComparer<WorkDirectiveContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkDirectiveContainsRelationship? left, WorkDirectiveContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkDirectiveContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}