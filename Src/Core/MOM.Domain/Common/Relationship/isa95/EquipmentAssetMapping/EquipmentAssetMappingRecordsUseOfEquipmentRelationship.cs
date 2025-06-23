namespace MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping
{
    /// <summary>
    ///
    /// </summary>
    public class EquipmentAssetMappingRecordsUseOfEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentAssetMapping, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>, IEquatable<EquipmentAssetMappingRecordsUseOfEquipmentRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "RecordsUseOfEquipment";

        /// <inheritdoc/>
        public EquipmentAssetMappingRecordsUseOfEquipmentRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentAssetMapping source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment target) : base(source, target)
        {
        }

        /// <inheritdoc/>
        public EquipmentAssetMappingRecordsUseOfEquipmentRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        /// <inheritdoc/>
        public EquipmentAssetMappingRecordsUseOfEquipmentRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        /// <inheritdoc/>
        public EquipmentAssetMappingRecordsUseOfEquipmentRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentAssetMappingRecordsUseOfEquipmentRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentAssetMappingRecordsUseOfEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentAssetMappingRecordsUseOfEquipmentRelationship? left, EquipmentAssetMappingRecordsUseOfEquipmentRelationship? right)
        {
            return EqualityComparer<EquipmentAssetMappingRecordsUseOfEquipmentRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentAssetMappingRecordsUseOfEquipmentRelationship? left, EquipmentAssetMappingRecordsUseOfEquipmentRelationship? right)
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
            return Equals(other as EquipmentAssetMappingRecordsUseOfEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}