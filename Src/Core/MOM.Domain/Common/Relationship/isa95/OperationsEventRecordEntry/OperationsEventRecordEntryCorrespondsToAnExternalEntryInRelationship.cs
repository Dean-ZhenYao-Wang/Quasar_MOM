namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecordEntry
{
    public class OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship : Relationship<BaseEntity>, IEquatable<OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship>
    {
        public OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship()
        {
            Name = "correspondsToAnExternalEntryIn";
        }

        public OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecordEntry source, BaseEntity target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship);
        }

        public bool Equals(OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship? left, OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship? right)
        {
            return EqualityComparer<OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship? left, OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}