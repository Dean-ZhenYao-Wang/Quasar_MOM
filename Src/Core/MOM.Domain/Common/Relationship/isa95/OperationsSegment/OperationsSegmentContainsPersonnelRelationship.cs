namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentContainsPersonnelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification>, IEquatable<OperationsSegmentContainsPersonnelRelationship>
    {
        public OperationsSegmentContainsPersonnelRelationship()
        {
            Name = "containsPersonnel";
        }

        public OperationsSegmentContainsPersonnelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentContainsPersonnelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentContainsPersonnelRelationship);
        }

        public bool Equals(OperationsSegmentContainsPersonnelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentContainsPersonnelRelationship? left, OperationsSegmentContainsPersonnelRelationship? right)
        {
            return EqualityComparer<OperationsSegmentContainsPersonnelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentContainsPersonnelRelationship? left, OperationsSegmentContainsPersonnelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentContainsPersonnelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}