namespace MOM.Domain.Common.Relationship.isa95.OperationsEventProperty
{
    public class OperationsEventPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionProperty>, IEquatable<OperationsEventPropertyMapsToRelationship>
    {
        public OperationsEventPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public OperationsEventPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventPropertyMapsToRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventPropertyMapsToRelationship);
        }

        public bool Equals(OperationsEventPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventPropertyMapsToRelationship? left, OperationsEventPropertyMapsToRelationship? right)
        {
            return EqualityComparer<OperationsEventPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventPropertyMapsToRelationship? left, OperationsEventPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}