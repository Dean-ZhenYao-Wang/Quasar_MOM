namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>, IEquatable<MaterialLotDefinedByRelationship>
    {
        public MaterialLotDefinedByRelationship()
        {
            Name = "definedBy";
        }

        public MaterialLotDefinedByRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialLotDefinedByRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialLotDefinedByRelationship);
        }

        public bool Equals(MaterialLotDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialLotDefinedByRelationship? left, MaterialLotDefinedByRelationship? right)
        {
            return EqualityComparer<MaterialLotDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialLotDefinedByRelationship? left, MaterialLotDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialLotDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}