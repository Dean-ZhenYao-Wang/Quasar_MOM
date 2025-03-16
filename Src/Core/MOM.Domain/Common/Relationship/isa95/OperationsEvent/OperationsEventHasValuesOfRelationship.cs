namespace MOM.Domain.Common.Relationship.isa95.OperationsEvent
{
    public class OperationsEventHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventProperty>, IEquatable<OperationsEventHasValuesOfRelationship>
    {
        public OperationsEventHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public OperationsEventHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEvent source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventHasValuesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventHasValuesOfRelationship);
        }

        public bool Equals(OperationsEventHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventHasValuesOfRelationship? left, OperationsEventHasValuesOfRelationship? right)
        {
            return EqualityComparer<OperationsEventHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventHasValuesOfRelationship? left, OperationsEventHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}