namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClass
{
    public class OperationalLocationClassIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass>, IEquatable<OperationalLocationClassIncludesPropertiesOfRelationship>
    {
        public OperationalLocationClassIncludesPropertiesOfRelationship()
        {
            Name = "includesPropertiesOf";
        }

        public OperationalLocationClassIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationalLocationClassIncludesPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationClassIncludesPropertiesOfRelationship);
        }

        public bool Equals(OperationalLocationClassIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationalLocationClassIncludesPropertiesOfRelationship? left, OperationalLocationClassIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<OperationalLocationClassIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationClassIncludesPropertiesOfRelationship? left, OperationalLocationClassIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationalLocationClassIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}