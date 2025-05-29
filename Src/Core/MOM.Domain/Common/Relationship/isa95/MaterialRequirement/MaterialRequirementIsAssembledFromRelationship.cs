namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementIsAssembledFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement,Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement>, IEquatable<MaterialRequirementIsAssembledFromRelationship>
    {
        public MaterialRequirementIsAssembledFromRelationship()
        {
            Name = "IsAssembledFrom";
        }

        public MaterialRequirementIsAssembledFromRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementIsAssembledFromRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementIsAssembledFromRelationship);
        }

        public bool Equals(MaterialRequirementIsAssembledFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementIsAssembledFromRelationship? left, MaterialRequirementIsAssembledFromRelationship? right)
        {
            return EqualityComparer<MaterialRequirementIsAssembledFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementIsAssembledFromRelationship? left, MaterialRequirementIsAssembledFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementIsAssembledFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}