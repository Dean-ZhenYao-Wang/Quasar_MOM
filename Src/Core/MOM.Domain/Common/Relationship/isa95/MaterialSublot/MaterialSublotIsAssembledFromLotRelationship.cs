namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotIsAssembledFromLotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>, IEquatable<MaterialSublotIsAssembledFromLotRelationship>
    {
        public MaterialSublotIsAssembledFromLotRelationship()
        {
            Name = "isAssembledFromLot";
        }

        public MaterialSublotIsAssembledFromLotRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSublotIsAssembledFromLotRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSublotIsAssembledFromLotRelationship);
        }

        public bool Equals(MaterialSublotIsAssembledFromLotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSublotIsAssembledFromLotRelationship? left, MaterialSublotIsAssembledFromLotRelationship? right)
        {
            return EqualityComparer<MaterialSublotIsAssembledFromLotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSublotIsAssembledFromLotRelationship? left, MaterialSublotIsAssembledFromLotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSublotIsAssembledFromLotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}