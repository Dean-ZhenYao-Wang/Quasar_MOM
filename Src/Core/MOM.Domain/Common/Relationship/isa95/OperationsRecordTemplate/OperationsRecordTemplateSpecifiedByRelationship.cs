namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordTemplate
{
    public class OperationsRecordTemplateSpecifiedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordSpecificationTemplate>, IEquatable<OperationsRecordTemplateSpecifiedByRelationship>
    {
        public OperationsRecordTemplateSpecifiedByRelationship()
        {
            Name = "specifiedBy";
        }

        public OperationsRecordTemplateSpecifiedByRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordTemplate source, Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordSpecificationTemplate target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsRecordTemplateSpecifiedByRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRecordTemplateSpecifiedByRelationship);
        }

        public bool Equals(OperationsRecordTemplateSpecifiedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsRecordTemplateSpecifiedByRelationship? left, OperationsRecordTemplateSpecifiedByRelationship? right)
        {
            return EqualityComparer<OperationsRecordTemplateSpecifiedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRecordTemplateSpecifiedByRelationship? left, OperationsRecordTemplateSpecifiedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsRecordTemplateSpecifiedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}