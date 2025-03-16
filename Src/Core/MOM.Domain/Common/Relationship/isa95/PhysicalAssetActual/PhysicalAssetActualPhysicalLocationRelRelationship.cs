namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual
{
    public class PhysicalAssetActualPhysicalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PhysicalAssetActualPhysicalLocationRelRelationship>
    {
        public PhysicalAssetActualPhysicalLocationRelRelationship()
        {
            Name = "physicalLocationRel";
        }

        public PhysicalAssetActualPhysicalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetActualPhysicalLocationRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetActualPhysicalLocationRelRelationship);
        }

        public bool Equals(PhysicalAssetActualPhysicalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetActualPhysicalLocationRelRelationship? left, PhysicalAssetActualPhysicalLocationRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetActualPhysicalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetActualPhysicalLocationRelRelationship? left, PhysicalAssetActualPhysicalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetActualPhysicalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}