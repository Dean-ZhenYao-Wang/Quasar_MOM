namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionContainsMaterialRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification>, IEquatable<WorkDefinitionContainsMaterialRelationship>
    {
        public WorkDefinitionContainsMaterialRelationship()
        {
            Name = "containsMaterial";
        }

        public WorkDefinitionContainsMaterialRelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkDefinitionContainsMaterialRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkDefinitionContainsMaterialRelationship);
        }

        public bool Equals(WorkDefinitionContainsMaterialRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkDefinitionContainsMaterialRelationship? left, WorkDefinitionContainsMaterialRelationship? right)
        {
            return EqualityComparer<WorkDefinitionContainsMaterialRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkDefinitionContainsMaterialRelationship? left, WorkDefinitionContainsMaterialRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkDefinitionContainsMaterialRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}