namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationCorrespondsToLotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>, IEquatable<MaterialSpecificationCorrespondsToLotRelationship>
    {
        public MaterialSpecificationCorrespondsToLotRelationship()
        {
            Name = "correspondsToLot";
        }

        public MaterialSpecificationCorrespondsToLotRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSpecificationCorrespondsToLotRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSpecificationCorrespondsToLotRelationship);
        }

        public bool Equals(MaterialSpecificationCorrespondsToLotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSpecificationCorrespondsToLotRelationship? left, MaterialSpecificationCorrespondsToLotRelationship? right)
        {
            return EqualityComparer<MaterialSpecificationCorrespondsToLotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSpecificationCorrespondsToLotRelationship? left, MaterialSpecificationCorrespondsToLotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSpecificationCorrespondsToLotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}