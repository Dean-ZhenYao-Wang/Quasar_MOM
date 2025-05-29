namespace MOM.Domain.isa95.CommonObjectModels.Part2.ProcessSegment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.ProcessSegment;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ProcessSegment : Resource, IEquatable<ProcessSegment>
    {
        public ProcessSegment()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ProcessSegment;1";

        [JsonPropertyName("operationsType")]
        public ProcessSegmentOperationsType? OperationsType { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("definitionType")]
        public ProcessSegmentDefinitionType? DefinitionType { get; set; }

        [JsonPropertyName("duration")]
        public string? Duration { get; set; }

        [JsonPropertyName("durationUnitOfMeasure")]
        public string? DurationUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<ProcessSegmentIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<ProcessSegmentIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<ProcessSegmentIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<ProcessSegmentIncludesPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<ProcessSegmentHasAnExecutionDependencyOnRelationship> HasAnExecutionDependencyOn { get; set; } = new List<ProcessSegmentHasAnExecutionDependencyOnRelationship>();

        [JsonIgnore]
public virtual List<ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship> HasAnExecutionDependencyOnSegment { get; set; } = new List<ProcessSegmentHasAnExecutionDependencyOnSegmentRelationship>();

        [JsonIgnore]
public virtual List<ProcessSegmentContainsParameterRelationship> ContainsParameter { get; set; } = new List<ProcessSegmentContainsParameterRelationship>();

        [JsonIgnore]
public virtual List<ProcessSegmentContainsPersonnelSpecificationRelationship> ContainsPersonnelSpecification { get; set; } = new List<ProcessSegmentContainsPersonnelSpecificationRelationship>();

        [JsonIgnore]
public virtual List<ProcessSegmentContainsEquipmentSpecificationRelationship> ContainsEquipmentSpecification { get; set; } = new List<ProcessSegmentContainsEquipmentSpecificationRelationship>();

        [JsonIgnore]
public virtual List<ProcessSegmentContainsPhysicalAssetSpecificationRelationship> ContainsPhysicalAssetSpecification { get; set; } = new List<ProcessSegmentContainsPhysicalAssetSpecificationRelationship>();

        [JsonIgnore]
public virtual List<ProcessSegmentContainsMaterialSpecificationRelationship> ContainsMaterialSpecification { get; set; } = new List<ProcessSegmentContainsMaterialSpecificationRelationship>();

        [JsonIgnore]
public virtual List<ProcessSegmentHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<ProcessSegmentHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegment);
        }

        public bool Equals(ProcessSegment? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && HierarchyScope == other.HierarchyScope && DefinitionType == other.DefinitionType && Duration == other.Duration && DurationUnitOfMeasure == other.DurationUnitOfMeasure;
        }

        public static bool operator ==(ProcessSegment? left, ProcessSegment? right)
        {
            return EqualityComparer<ProcessSegment?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegment? left, ProcessSegment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), HierarchyScope?.GetHashCode(), DefinitionType?.GetHashCode(), Duration?.GetHashCode(), DurationUnitOfMeasure?.GetHashCode());
        }
    }
}