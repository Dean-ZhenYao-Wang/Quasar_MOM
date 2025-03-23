namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClass
{
    public class OperationsEventClassIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass>, IEquatable<OperationsEventClassIncludesPropertiesOfRelationship>
    {
        public OperationsEventClassIncludesPropertiesOfRelationship()
        {
            Name = "includesPropertiesOf";
        }

        public OperationsEventClassIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass source, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventClassIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventClassIncludesPropertiesOfRelationship);
        }

        public bool Equals(OperationsEventClassIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventClassIncludesPropertiesOfRelationship? left, OperationsEventClassIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<OperationsEventClassIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventClassIncludesPropertiesOfRelationship? left, OperationsEventClassIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventClassIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}