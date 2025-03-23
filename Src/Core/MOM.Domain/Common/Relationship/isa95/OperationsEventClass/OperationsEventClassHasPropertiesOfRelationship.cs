namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClass
{
    public class OperationsEventClassHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassProperty>, IEquatable<OperationsEventClassHasPropertiesOfRelationship>
    {
        public OperationsEventClassHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public OperationsEventClassHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventClassHasPropertiesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventClassHasPropertiesOfRelationship);
        }

        public bool Equals(OperationsEventClassHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventClassHasPropertiesOfRelationship? left, OperationsEventClassHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<OperationsEventClassHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventClassHasPropertiesOfRelationship? left, OperationsEventClassHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventClassHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}