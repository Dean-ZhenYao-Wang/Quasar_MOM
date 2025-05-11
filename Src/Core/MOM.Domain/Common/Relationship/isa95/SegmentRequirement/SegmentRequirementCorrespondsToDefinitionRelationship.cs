namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementCorrespondsToDefinitionRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>, IEquatable<SegmentRequirementCorrespondsToDefinitionRelationship>
    {
        public SegmentRequirementCorrespondsToDefinitionRelationship()
        {
            Name = "correspondsToDefinition";
        }

        public SegmentRequirementCorrespondsToDefinitionRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentRequirementCorrespondsToDefinitionRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentRequirementCorrespondsToDefinitionRelationship);
        }

        public bool Equals(SegmentRequirementCorrespondsToDefinitionRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentRequirementCorrespondsToDefinitionRelationship? left, SegmentRequirementCorrespondsToDefinitionRelationship? right)
        {
            return EqualityComparer<SegmentRequirementCorrespondsToDefinitionRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentRequirementCorrespondsToDefinitionRelationship? left, SegmentRequirementCorrespondsToDefinitionRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentRequirementCorrespondsToDefinitionRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}