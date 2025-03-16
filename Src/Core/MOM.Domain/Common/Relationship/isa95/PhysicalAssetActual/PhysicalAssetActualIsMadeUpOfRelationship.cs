namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual
{
    public class PhysicalAssetActualIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual>, IEquatable<PhysicalAssetActualIsMadeUpOfRelationship>
    {
        public PhysicalAssetActualIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public PhysicalAssetActualIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetActualIsMadeUpOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetActualIsMadeUpOfRelationship);
        }

        public bool Equals(PhysicalAssetActualIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetActualIsMadeUpOfRelationship? left, PhysicalAssetActualIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetActualIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetActualIsMadeUpOfRelationship? left, PhysicalAssetActualIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetActualIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}