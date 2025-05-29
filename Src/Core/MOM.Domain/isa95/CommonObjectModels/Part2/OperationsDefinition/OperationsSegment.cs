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
public virtual List<OperationsSegmentCorrespondsToRelationship> CorrespondsTo { get; set; } = new List<OperationsSegmentCorrespondsToRelationship>();

        [JsonIgnore]
public virtual List<OperationsSegmentIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<OperationsSegmentIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<OperationsSegmentHasAnExecutionDependencyOnRelationship> HasAnExecutionDependencyOn { get; set; } = new List<OperationsSegmentHasAnExecutionDependencyOnRelationship>();

        [JsonIgnore]
public virtual List<OperationsSegmentIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<OperationsSegmentIncludesPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship> HasAnExecutionDependencyOnSegment { get; set; } = new List<OperationsSegmentHasAnExecutionDependencyOnSegmentRelationship>();

        [JsonIgnore]
public virtual List<OperationsSegmentContainsParameterRelationship> ContainsParameter { get; set; } = new List<OperationsSegmentContainsParameterRelationship>();

        [JsonIgnore]
public virtual List<OperationsSegmentContainsPersonnelRelationship> ContainsPersonnel { get; set; } = new List<OperationsSegmentContainsPersonnelRelationship>();

        [JsonIgnore]
public virtual List<OperationsSegmentContainsEquipmentRelationship> ContainsEquipment { get; set; } = new List<OperationsSegmentContainsEquipmentRelationship>();

        [JsonIgnore]
public virtual List<OperationsSegmentContainsPhysicalAssetRelationship> ContainsPhysicalAsset { get; set; } = new List<OperationsSegmentContainsPhysicalAssetRelationship>();

        [JsonIgnore]
public virtual List<OperationsSegmentContainsMaterialRelationship> ContainsMaterial { get; set; } = new List<OperationsSegmentContainsMaterialRelationship>();

        [JsonIgnore]
public virtual List<OperationsSegmentHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<OperationsSegmentHierarchyScopeRelRelationship>();

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