namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordEntryTemplate
{
    public class OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship : Relationship<BaseEntity>, IEquatable<OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship>
    {
        public OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship()
        {
            Name = "correspondsToAnExternalEntryIn";
        }

        public OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordEntryTemplate source, BaseEntity target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship);
        }

        public bool Equals(OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship? left, OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship? right)
        {
            return EqualityComparer<OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship? left, OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}