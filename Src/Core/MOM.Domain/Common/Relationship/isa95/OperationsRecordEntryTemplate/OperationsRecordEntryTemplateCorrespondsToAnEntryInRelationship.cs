namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordEntryTemplate
{
    public class OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship : Relationship<BaseEntity>, IEquatable<OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship>
    {
        public OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship()
        {
            Name = "correspondsToAnEntryIn";
        }

        public OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordEntryTemplate source, BaseEntity target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship);
        }

        public bool Equals(OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship? left, OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship? right)
        {
            return EqualityComparer<OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship? left, OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}