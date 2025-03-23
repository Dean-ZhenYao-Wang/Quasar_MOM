namespace MOM.Domain.Common.Relationship.isa95.OperationsDefinition
{
    public class OperationsDefinitionHasAssociatedRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBill>, IEquatable<OperationsDefinitionHasAssociatedRelationship>
    {
        public OperationsDefinitionHasAssociatedRelationship()
        {
            Name = "hasAssociated";
        }

        public OperationsDefinitionHasAssociatedRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBill target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsDefinitionHasAssociatedRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsDefinitionHasAssociatedRelationship);
        }

        public bool Equals(OperationsDefinitionHasAssociatedRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsDefinitionHasAssociatedRelationship? left, OperationsDefinitionHasAssociatedRelationship? right)
        {
            return EqualityComparer<OperationsDefinitionHasAssociatedRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsDefinitionHasAssociatedRelationship? left, OperationsDefinitionHasAssociatedRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsDefinitionHasAssociatedRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}