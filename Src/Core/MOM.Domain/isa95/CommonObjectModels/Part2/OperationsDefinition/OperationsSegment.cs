namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsSegment;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class OperationsSegment : Resource, IEquatable<OperationsSegment>
    {
        public OperationsSegment()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsSegment;1";

        [JsonPropertyName("operationsType")]
        public OperationsSegmentOperationsType? OperationsType { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("definitionType")]
        public OperationsSegmentDefinitionType? DefinitionType { get; set; }

        [JsonPropertyName("duration")]
        public string? Duration { get; set; }

        [JsonPropertyName("durationUnitOfMeasure")]
        public string? DurationUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual OperationsSegmentCorrespondsToRelationshipCollection CorrespondsTo { get; set; } = new OperationsSegmentCorrespondsToRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsSegmentIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new OperationsSegmentIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsSegmentHasAnExecutionDependencyOnRelationshipCollection HasAnExecutionDependencyOn { get; set; } = new OperationsSegmentHasAnExecutionDependencyOnRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsSegmentIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new OperationsSegmentIncludesPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsSegmentHasAnExecutionDependencyOnSegmentRelationshipCollection HasAnExecutionDependencyOnSegment { get; set; } = new OperationsSegmentHasAnExecutionDependencyOnSegmentRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsSegmentContainsParameterRelationshipCollection ContainsParameter { get; set; } = new OperationsSegmentContainsParameterRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsSegmentContainsPersonnelRelationshipCollection ContainsPersonnel { get; set; } = new OperationsSegmentContainsPersonnelRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsSegmentContainsEquipmentRelationshipCollection ContainsEquipment { get; set; } = new OperationsSegmentContainsEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsSegmentContainsPhysicalAssetRelationshipCollection ContainsPhysicalAsset { get; set; } = new OperationsSegmentContainsPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsSegmentContainsMaterialRelationshipCollection ContainsMaterial { get; set; } = new OperationsSegmentContainsMaterialRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsSegmentHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new OperationsSegmentHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegment);
        }

        public bool Equals(OperationsSegment? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && HierarchyScope == other.HierarchyScope && DefinitionType == other.DefinitionType && Duration == other.Duration && DurationUnitOfMeasure == other.DurationUnitOfMeasure;
        }

        public static bool operator ==(OperationsSegment? left, OperationsSegment? right)
        {
            return EqualityComparer<OperationsSegment?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegment? left, OperationsSegment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), HierarchyScope?.GetHashCode(), DefinitionType?.GetHashCode(), Duration?.GetHashCode(), DurationUnitOfMeasure?.GetHashCode());
        }
    }
}