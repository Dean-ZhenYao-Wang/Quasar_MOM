namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordSpecificationTemplate
{
    public class OperationsRecordSpecificationTemplateContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordSpecificationTemplate>, IEquatable<OperationsRecordSpecificationTemplateContainsRelationship>
    {
        public OperationsRecordSpecificationTemplateContainsRelationship()
        {
            Name = "contains";
        }

        public OperationsRecordSpecificationTemplateContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordSpecificationTemplate source, Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordSpecificationTemplate target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsRecordSpecificationTemplateContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRecordSpecificationTemplateContainsRelationship);
        }

        public bool Equals(OperationsRecordSpecificationTemplateContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsRecordSpecificationTemplateContainsRelationship? left, OperationsRecordSpecificationTemplateContainsRelationship? right)
        {
            return EqualityComparer<OperationsRecordSpecificationTemplateContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRecordSpecificationTemplateContainsRelationship? left, OperationsRecordSpecificationTemplateContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsRecordSpecificationTemplateContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}