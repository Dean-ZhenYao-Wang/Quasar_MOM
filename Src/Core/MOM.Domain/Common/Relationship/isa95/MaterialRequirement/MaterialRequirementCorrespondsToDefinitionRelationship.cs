namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementCorrespondsToDefinitionRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>, IEquatable<MaterialRequirementCorrespondsToDefinitionRelationship>
    {
        public MaterialRequirementCorrespondsToDefinitionRelationship()
        {
            Name = "correspondsToDefinition";
        }

        public MaterialRequirementCorrespondsToDefinitionRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementCorrespondsToDefinitionRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementCorrespondsToDefinitionRelationship);
        }

        public bool Equals(MaterialRequirementCorrespondsToDefinitionRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementCorrespondsToDefinitionRelationship? left, MaterialRequirementCorrespondsToDefinitionRelationship? right)
        {
            return EqualityComparer<MaterialRequirementCorrespondsToDefinitionRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementCorrespondsToDefinitionRelationship? left, MaterialRequirementCorrespondsToDefinitionRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementCorrespondsToDefinitionRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}