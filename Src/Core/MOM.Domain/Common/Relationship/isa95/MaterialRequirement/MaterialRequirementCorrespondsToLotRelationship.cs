namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementCorrespondsToLotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>, IEquatable<MaterialRequirementCorrespondsToLotRelationship>
    {
        public MaterialRequirementCorrespondsToLotRelationship()
        {
            Name = "correspondsToLot";
        }

        public MaterialRequirementCorrespondsToLotRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementCorrespondsToLotRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementCorrespondsToLotRelationship);
        }

        public bool Equals(MaterialRequirementCorrespondsToLotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementCorrespondsToLotRelationship? left, MaterialRequirementCorrespondsToLotRelationship? right)
        {
            return EqualityComparer<MaterialRequirementCorrespondsToLotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementCorrespondsToLotRelationship? left, MaterialRequirementCorrespondsToLotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementCorrespondsToLotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}