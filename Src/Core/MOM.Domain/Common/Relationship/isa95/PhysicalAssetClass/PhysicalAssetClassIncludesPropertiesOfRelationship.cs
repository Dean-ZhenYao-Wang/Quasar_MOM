namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass
{
    public class PhysicalAssetClassIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>, IEquatable<PhysicalAssetClassIncludesPropertiesOfRelationship>
    {
        public PhysicalAssetClassIncludesPropertiesOfRelationship()
        {
            Name = "includesPropertiesOf";
        }

        public PhysicalAssetClassIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetClassIncludesPropertiesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetClassIncludesPropertiesOfRelationship);
        }

        public bool Equals(PhysicalAssetClassIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetClassIncludesPropertiesOfRelationship? left, PhysicalAssetClassIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetClassIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetClassIncludesPropertiesOfRelationship? left, PhysicalAssetClassIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetClassIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}