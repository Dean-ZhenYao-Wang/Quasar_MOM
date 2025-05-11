namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinition
{
    public class OperationsEventDefinitionHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionProperty>, IEquatable<OperationsEventDefinitionHasPropertiesOfRelationship>
    {
        public OperationsEventDefinitionHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public OperationsEventDefinitionHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventDefinitionHasPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinitionHasPropertiesOfRelationship);
        }

        public bool Equals(OperationsEventDefinitionHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventDefinitionHasPropertiesOfRelationship? left, OperationsEventDefinitionHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<OperationsEventDefinitionHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinitionHasPropertiesOfRelationship? left, OperationsEventDefinitionHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventDefinitionHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}