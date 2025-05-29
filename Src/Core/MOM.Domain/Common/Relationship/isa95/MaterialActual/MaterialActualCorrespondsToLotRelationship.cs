namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualCorrespondsToLotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual,Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>, IEquatable<MaterialActualCorrespondsToLotRelationship>
    {
        public MaterialActualCorrespondsToLotRelationship()
        {
            Name = "correspondsToLot";
        }

        public MaterialActualCorrespondsToLotRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialActualCorrespondsToLotRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActualCorrespondsToLotRelationship);
        }

        public bool Equals(MaterialActualCorrespondsToLotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialActualCorrespondsToLotRelationship? left, MaterialActualCorrespondsToLotRelationship? right)
        {
            return EqualityComparer<MaterialActualCorrespondsToLotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActualCorrespondsToLotRelationship? left, MaterialActualCorrespondsToLotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialActualCorrespondsToLotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}