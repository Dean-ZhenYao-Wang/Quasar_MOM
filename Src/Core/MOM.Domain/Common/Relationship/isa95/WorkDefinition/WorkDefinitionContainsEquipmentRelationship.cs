namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionContainsEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification>, IEquatable<WorkDefinitionContainsEquipmentRelationship>
    {
        public WorkDefinitionContainsEquipmentRelationship()
        {
            Name = "containsEquipment";
        }

        public WorkDefinitionContainsEquipmentRelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkDefinitionContainsEquipmentRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkDefinitionContainsEquipmentRelationship);
        }

        public bool Equals(WorkDefinitionContainsEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkDefinitionContainsEquipmentRelationship? left, WorkDefinitionContainsEquipmentRelationship? right)
        {
            return EqualityComparer<WorkDefinitionContainsEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkDefinitionContainsEquipmentRelationship? left, WorkDefinitionContainsEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkDefinitionContainsEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}