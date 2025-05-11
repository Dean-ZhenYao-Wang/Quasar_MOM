namespace MOM.Domain.Common.Relationship.isa95.OperationsEvent
{
    public class OperationsEventIsACollectionOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecord>, IEquatable<OperationsEventIsACollectionOfRelationship>
    {
        public OperationsEventIsACollectionOfRelationship()
        {
            Name = "isACollectionOf";
        }

        public OperationsEventIsACollectionOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEvent source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecord target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventIsACollectionOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventIsACollectionOfRelationship);
        }

        public bool Equals(OperationsEventIsACollectionOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventIsACollectionOfRelationship? left, OperationsEventIsACollectionOfRelationship? right)
        {
            return EqualityComparer<OperationsEventIsACollectionOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventIsACollectionOfRelationship? left, OperationsEventIsACollectionOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventIsACollectionOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}