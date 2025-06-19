
namespace MOM.Domain.Common.Relationship.isa95.EquipmentClass
{
    /// <summary>
    /// 
    /// </summary>
    public class EquipmentClassIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass ,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>, IEquatable<EquipmentClassIncludesPropertiesOfRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "includesPropertiesOf";

        /// <inheritdoc/>
        public EquipmentClassIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target) : base(source, target)
        {
        }

        /// <inheritdoc/>
        public EquipmentClassIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        /// <inheritdoc/>
        public EquipmentClassIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        /// <inheritdoc/>
        public EquipmentClassIncludesPropertiesOfRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target, int depth) : base(sourceId, target, depth)
        {
        }


        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClassIncludesPropertiesOfRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentClassIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentClassIncludesPropertiesOfRelationship? left, EquipmentClassIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<EquipmentClassIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentClassIncludesPropertiesOfRelationship? left, EquipmentClassIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        /// <inheritdoc/>
        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentClassIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}