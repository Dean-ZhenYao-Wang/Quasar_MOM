namespace MOM.Domain.Common.Relationship.isa95.WorkDirective
{
    public class WorkDirectiveIsCretaedFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>, IEquatable<WorkDirectiveIsCretaedFromRelationship>
    {
        public WorkDirectiveIsCretaedFromRelationship()
        {
            Name = "isCretaedFrom";
        }

        public WorkDirectiveIsCretaedFromRelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDirective source, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkDirectiveIsCretaedFromRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkDirectiveIsCretaedFromRelationship);
        }

        public bool Equals(WorkDirectiveIsCretaedFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkDirectiveIsCretaedFromRelationship? left, WorkDirectiveIsCretaedFromRelationship? right)
        {
            return EqualityComparer<WorkDirectiveIsCretaedFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkDirectiveIsCretaedFromRelationship? left, WorkDirectiveIsCretaedFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkDirectiveIsCretaedFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}