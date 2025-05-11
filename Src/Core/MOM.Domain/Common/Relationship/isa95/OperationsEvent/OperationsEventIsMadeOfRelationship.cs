namespace MOM.Domain.Common.Relationship.isa95.OperationsEvent
{
    public class OperationsEventIsMadeOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEvent>, IEquatable<OperationsEventIsMadeOfRelationship>
    {
        public OperationsEventIsMadeOfRelationship()
        {
            Name = "isMadeOf";
        }

        public OperationsEventIsMadeOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEvent source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEvent target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventIsMadeOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventIsMadeOfRelationship);
        }

        public bool Equals(OperationsEventIsMadeOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventIsMadeOfRelationship? left, OperationsEventIsMadeOfRelationship? right)
        {
            return EqualityComparer<OperationsEventIsMadeOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventIsMadeOfRelationship? left, OperationsEventIsMadeOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventIsMadeOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}