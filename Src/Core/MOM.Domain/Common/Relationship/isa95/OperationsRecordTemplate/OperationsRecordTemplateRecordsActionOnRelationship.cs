namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordTemplate
{
    public class OperationsRecordTemplateRecordsActionOnRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordEntryTemplate>, IEquatable<OperationsRecordTemplateRecordsActionOnRelationship>
    {
        public OperationsRecordTemplateRecordsActionOnRelationship()
        {
            Name = "recordsActionOn";
        }

        public OperationsRecordTemplateRecordsActionOnRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordTemplate source, Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordEntryTemplate target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsRecordTemplateRecordsActionOnRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRecordTemplateRecordsActionOnRelationship);
        }

        public bool Equals(OperationsRecordTemplateRecordsActionOnRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsRecordTemplateRecordsActionOnRelationship? left, OperationsRecordTemplateRecordsActionOnRelationship? right)
        {
            return EqualityComparer<OperationsRecordTemplateRecordsActionOnRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRecordTemplateRecordsActionOnRelationship? left, OperationsRecordTemplateRecordsActionOnRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsRecordTemplateRecordsActionOnRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}