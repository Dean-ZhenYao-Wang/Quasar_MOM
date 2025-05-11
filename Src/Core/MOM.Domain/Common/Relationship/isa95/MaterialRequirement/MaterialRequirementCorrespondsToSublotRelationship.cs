namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementCorrespondsToSublotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>, IEquatable<MaterialRequirementCorrespondsToSublotRelationship>
    {
        public MaterialRequirementCorrespondsToSublotRelationship()
        {
            Name = "correspondsToSublot";
        }

        public MaterialRequirementCorrespondsToSublotRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementCorrespondsToSublotRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementCorrespondsToSublotRelationship);
        }

        public bool Equals(MaterialRequirementCorrespondsToSublotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementCorrespondsToSublotRelationship? left, MaterialRequirementCorrespondsToSublotRelationship? right)
        {
            return EqualityComparer<MaterialRequirementCorrespondsToSublotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementCorrespondsToSublotRelationship? left, MaterialRequirementCorrespondsToSublotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementCorrespondsToSublotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}