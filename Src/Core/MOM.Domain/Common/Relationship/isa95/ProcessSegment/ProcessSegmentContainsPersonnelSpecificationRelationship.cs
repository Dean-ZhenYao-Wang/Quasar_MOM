namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentContainsPersonnelSpecificationRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecification>, IEquatable<ProcessSegmentContainsPersonnelSpecificationRelationship>
    {
        public ProcessSegmentContainsPersonnelSpecificationRelationship()
        {
            Name = "containsPersonnelSpecification";
        }

        public ProcessSegmentContainsPersonnelSpecificationRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment source, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentContainsPersonnelSpecificationRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentContainsPersonnelSpecificationRelationship);
        }

        public bool Equals(ProcessSegmentContainsPersonnelSpecificationRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentContainsPersonnelSpecificationRelationship? left, ProcessSegmentContainsPersonnelSpecificationRelationship? right)
        {
            return EqualityComparer<ProcessSegmentContainsPersonnelSpecificationRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentContainsPersonnelSpecificationRelationship? left, ProcessSegmentContainsPersonnelSpecificationRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentContainsPersonnelSpecificationRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}