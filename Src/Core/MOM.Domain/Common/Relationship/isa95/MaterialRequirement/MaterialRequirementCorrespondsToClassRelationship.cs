namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementCorrespondsToClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>, IEquatable<MaterialRequirementCorrespondsToClassRelationship>
    {
        public MaterialRequirementCorrespondsToClassRelationship()
        {
            Name = "correspondsToClass";
        }

        public MaterialRequirementCorrespondsToClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementCorrespondsToClassRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementCorrespondsToClassRelationship);
        }

        public bool Equals(MaterialRequirementCorrespondsToClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementCorrespondsToClassRelationship? left, MaterialRequirementCorrespondsToClassRelationship? right)
        {
            return EqualityComparer<MaterialRequirementCorrespondsToClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementCorrespondsToClassRelationship? left, MaterialRequirementCorrespondsToClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementCorrespondsToClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}