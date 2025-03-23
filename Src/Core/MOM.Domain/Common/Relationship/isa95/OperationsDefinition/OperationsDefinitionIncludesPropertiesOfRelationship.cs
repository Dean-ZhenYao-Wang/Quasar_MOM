namespace MOM.Domain.Common.Relationship.isa95.OperationsDefinition
{
    public class OperationsDefinitionIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>, IEquatable<OperationsDefinitionIncludesPropertiesOfRelationship>
    {
        public OperationsDefinitionIncludesPropertiesOfRelationship()
        {
            Name = "includesPropertiesOf";
        }

        public OperationsDefinitionIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsDefinitionIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsDefinitionIncludesPropertiesOfRelationship);
        }

        public bool Equals(OperationsDefinitionIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsDefinitionIncludesPropertiesOfRelationship? left, OperationsDefinitionIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<OperationsDefinitionIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsDefinitionIncludesPropertiesOfRelationship? left, OperationsDefinitionIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsDefinitionIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}