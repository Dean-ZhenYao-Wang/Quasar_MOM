namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotIsAssembledFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot ,Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>, IEquatable<MaterialLotIsAssembledFromRelationship>
    {
        override public string Name { get; set; } = "isAssembledFrom";

        public MaterialLotIsAssembledFromRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot target) : base(source, target)
        {
        }
        public MaterialLotIsAssembledFromRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialLotIsAssembledFromRelationship);
        }

        public bool Equals(MaterialLotIsAssembledFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialLotIsAssembledFromRelationship? left, MaterialLotIsAssembledFromRelationship? right)
        {
            return EqualityComparer<MaterialLotIsAssembledFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialLotIsAssembledFromRelationship? left, MaterialLotIsAssembledFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialLotIsAssembledFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}