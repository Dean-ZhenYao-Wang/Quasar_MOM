namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordEntryTemplate
{
    public class OperationsRecordEntryTemplateContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordEntryTemplate>, IEquatable<OperationsRecordEntryTemplateContainsRelationship>
    {
        public OperationsRecordEntryTemplateContainsRelationship()
        {
            Name = "contains";
        }

        public OperationsRecordEntryTemplateContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordEntryTemplate source, Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordEntryTemplate target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsRecordEntryTemplateContainsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRecordEntryTemplateContainsRelationship);
        }

        public bool Equals(OperationsRecordEntryTemplateContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsRecordEntryTemplateContainsRelationship? left, OperationsRecordEntryTemplateContainsRelationship? right)
        {
            return EqualityComparer<OperationsRecordEntryTemplateContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRecordEntryTemplateContainsRelationship? left, OperationsRecordEntryTemplateContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsRecordEntryTemplateContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}