namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement,Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirementProperty>, IEquatable<MaterialRequirementHasValuesOfRelationship>
    {
        public MaterialRequirementHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public MaterialRequirementHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirementProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementHasValuesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementHasValuesOfRelationship);
        }

        public bool Equals(MaterialRequirementHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementHasValuesOfRelationship? left, MaterialRequirementHasValuesOfRelationship? right)
        {
            return EqualityComparer<MaterialRequirementHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementHasValuesOfRelationship? left, MaterialRequirementHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}