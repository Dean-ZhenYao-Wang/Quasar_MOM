namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotIsAssembledFromSublotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot ,Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>, IEquatable<MaterialLotIsAssembledFromSublotRelationship>
    {
        public MaterialLotIsAssembledFromSublotRelationship()
        {
            Name = "isAssembledFromSublot";
        }

        public MaterialLotIsAssembledFromSublotRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialLotIsAssembledFromSublotRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialLotIsAssembledFromSublotRelationship);
        }

        public bool Equals(MaterialLotIsAssembledFromSublotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialLotIsAssembledFromSublotRelationship? left, MaterialLotIsAssembledFromSublotRelationship? right)
        {
            return EqualityComparer<MaterialLotIsAssembledFromSublotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialLotIsAssembledFromSublotRelationship? left, MaterialLotIsAssembledFromSublotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialLotIsAssembledFromSublotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}