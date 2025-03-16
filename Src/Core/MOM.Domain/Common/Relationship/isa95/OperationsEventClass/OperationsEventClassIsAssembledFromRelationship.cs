namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClass
{
    public class OperationsEventClassIsAssembledFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass>, IEquatable<OperationsEventClassIsAssembledFromRelationship>
    {
        public OperationsEventClassIsAssembledFromRelationship()
        {
            Name = "isAssembledFrom";
        }

        public OperationsEventClassIsAssembledFromRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventClassIsAssembledFromRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventClassIsAssembledFromRelationship);
        }

        public bool Equals(OperationsEventClassIsAssembledFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventClassIsAssembledFromRelationship? left, OperationsEventClassIsAssembledFromRelationship? right)
        {
            return EqualityComparer<OperationsEventClassIsAssembledFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventClassIsAssembledFromRelationship? left, OperationsEventClassIsAssembledFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventClassIsAssembledFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}