namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotStorageLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<MaterialLotStorageLocationRelRelationship>
    {
        public MaterialLotStorageLocationRelRelationship()
        {
            Name = "storageLocationRel";
        }

        public MaterialLotStorageLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialLotStorageLocationRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialLotStorageLocationRelRelationship);
        }

        public bool Equals(MaterialLotStorageLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialLotStorageLocationRelRelationship? left, MaterialLotStorageLocationRelRelationship? right)
        {
            return EqualityComparer<MaterialLotStorageLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialLotStorageLocationRelRelationship? left, MaterialLotStorageLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialLotStorageLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}