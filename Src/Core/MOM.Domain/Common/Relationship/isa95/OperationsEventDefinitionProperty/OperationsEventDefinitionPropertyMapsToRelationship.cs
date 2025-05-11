namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinitionProperty
{
    public class OperationsEventDefinitionPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassProperty>, IEquatable<OperationsEventDefinitionPropertyMapsToRelationship>
    {
        public OperationsEventDefinitionPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public OperationsEventDefinitionPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventDefinitionPropertyMapsToRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinitionPropertyMapsToRelationship);
        }

        public bool Equals(OperationsEventDefinitionPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventDefinitionPropertyMapsToRelationship? left, OperationsEventDefinitionPropertyMapsToRelationship? right)
        {
            return EqualityComparer<OperationsEventDefinitionPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinitionPropertyMapsToRelationship? left, OperationsEventDefinitionPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventDefinitionPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}