namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseCorrespondsToDefinitionRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>, IEquatable<SegmentResponseCorrespondsToDefinitionRelationship>
    {
        public SegmentResponseCorrespondsToDefinitionRelationship()
        {
            Name = "correspondsToDefinition";
        }

        public SegmentResponseCorrespondsToDefinitionRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentResponseCorrespondsToDefinitionRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponseCorrespondsToDefinitionRelationship);
        }

        public bool Equals(SegmentResponseCorrespondsToDefinitionRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentResponseCorrespondsToDefinitionRelationship? left, SegmentResponseCorrespondsToDefinitionRelationship? right)
        {
            return EqualityComparer<SegmentResponseCorrespondsToDefinitionRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponseCorrespondsToDefinitionRelationship? left, SegmentResponseCorrespondsToDefinitionRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentResponseCorrespondsToDefinitionRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}