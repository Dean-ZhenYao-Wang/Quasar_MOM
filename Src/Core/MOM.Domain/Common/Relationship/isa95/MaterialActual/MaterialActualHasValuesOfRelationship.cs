namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual,Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty>, IEquatable<MaterialActualHasValuesOfRelationship>
    {
        public MaterialActualHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public MaterialActualHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialActualHasValuesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActualHasValuesOfRelationship);
        }

        public bool Equals(MaterialActualHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialActualHasValuesOfRelationship? left, MaterialActualHasValuesOfRelationship? right)
        {
            return EqualityComparer<MaterialActualHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActualHasValuesOfRelationship? left, MaterialActualHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialActualHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}