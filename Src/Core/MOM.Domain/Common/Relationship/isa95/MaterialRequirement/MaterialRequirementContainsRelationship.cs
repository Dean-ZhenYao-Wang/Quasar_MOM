namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement ,Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement>, IEquatable<MaterialRequirementContainsRelationship>
    {
        public MaterialRequirementContainsRelationship()
        {
            Name = "contains";
        }

        public MaterialRequirementContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementContainsRelationship);
        }

        public bool Equals(MaterialRequirementContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementContainsRelationship? left, MaterialRequirementContainsRelationship? right)
        {
            return EqualityComparer<MaterialRequirementContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementContainsRelationship? left, MaterialRequirementContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}