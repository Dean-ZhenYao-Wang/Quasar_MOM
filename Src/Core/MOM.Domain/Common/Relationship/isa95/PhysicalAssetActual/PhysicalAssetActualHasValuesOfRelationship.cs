namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual
{
    public class PhysicalAssetActualHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActualProperty>, IEquatable<PhysicalAssetActualHasValuesOfRelationship>
    {
        public PhysicalAssetActualHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public PhysicalAssetActualHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActualProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetActualHasValuesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetActualHasValuesOfRelationship);
        }

        public bool Equals(PhysicalAssetActualHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetActualHasValuesOfRelationship? left, PhysicalAssetActualHasValuesOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetActualHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetActualHasValuesOfRelationship? left, PhysicalAssetActualHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetActualHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}