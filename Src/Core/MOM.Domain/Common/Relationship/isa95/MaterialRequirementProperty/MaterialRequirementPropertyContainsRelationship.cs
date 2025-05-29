namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirementProperty
{
    public class MaterialRequirementPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirementProperty,Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirementProperty>, IEquatable<MaterialRequirementPropertyContainsRelationship>
    {
        public MaterialRequirementPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public MaterialRequirementPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirementProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementPropertyContainsRelationship);
        }

        public bool Equals(MaterialRequirementPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementPropertyContainsRelationship? left, MaterialRequirementPropertyContainsRelationship? right)
        {
            return EqualityComparer<MaterialRequirementPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementPropertyContainsRelationship? left, MaterialRequirementPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}