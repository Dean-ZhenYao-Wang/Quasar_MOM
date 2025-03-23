namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementStorageLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<MaterialRequirementStorageLocationRelRelationship>
    {
        public MaterialRequirementStorageLocationRelRelationship()
        {
            Name = "storageLocationRel";
        }

        public MaterialRequirementStorageLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementStorageLocationRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementStorageLocationRelRelationship);
        }

        public bool Equals(MaterialRequirementStorageLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementStorageLocationRelRelationship? left, MaterialRequirementStorageLocationRelRelationship? right)
        {
            return EqualityComparer<MaterialRequirementStorageLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementStorageLocationRelRelationship? left, MaterialRequirementStorageLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementStorageLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}