namespace MOM.Domain.Common.Relationship.isa95.ResourceActual
{
    public class ResourceActualReportsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestResult>, IEquatable<ResourceActualReportsRelationship>
    {
        public ResourceActualReportsRelationship()
        {
            Name = "reports";
        }

        public ResourceActualReportsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsTest.ResourceActual source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestResult target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ResourceActualReportsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceActualReportsRelationship);
        }

        public bool Equals(ResourceActualReportsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ResourceActualReportsRelationship? left, ResourceActualReportsRelationship? right)
        {
            return EqualityComparer<ResourceActualReportsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceActualReportsRelationship? left, ResourceActualReportsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ResourceActualReportsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}