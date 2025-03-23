namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionContainsPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification>, IEquatable<WorkDefinitionContainsPhysicalAssetRelationship>
    {
        public WorkDefinitionContainsPhysicalAssetRelationship()
        {
            Name = "containsPhysicalAsset";
        }

        public WorkDefinitionContainsPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkDefinitionContainsPhysicalAssetRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkDefinitionContainsPhysicalAssetRelationship);
        }

        public bool Equals(WorkDefinitionContainsPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkDefinitionContainsPhysicalAssetRelationship? left, WorkDefinitionContainsPhysicalAssetRelationship? right)
        {
            return EqualityComparer<WorkDefinitionContainsPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkDefinitionContainsPhysicalAssetRelationship? left, WorkDefinitionContainsPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkDefinitionContainsPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}