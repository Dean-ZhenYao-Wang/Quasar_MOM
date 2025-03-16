namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordTemplate
{
    public class OperationsRecordTemplateContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordTemplate>, IEquatable<OperationsRecordTemplateContainsRelationship>
    {
        public OperationsRecordTemplateContainsRelationship()
        {
            Name = "contains";
        }

        public OperationsRecordTemplateContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordTemplate source, Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordTemplate target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsRecordTemplateContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRecordTemplateContainsRelationship);
        }

        public bool Equals(OperationsRecordTemplateContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsRecordTemplateContainsRelationship? left, OperationsRecordTemplateContainsRelationship? right)
        {
            return EqualityComparer<OperationsRecordTemplateContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRecordTemplateContainsRelationship? left, OperationsRecordTemplateContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsRecordTemplateContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}