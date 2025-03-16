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
        public virtual ProcessSegmentIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new ProcessSegmentIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new ProcessSegmentIncludesPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentHasAnExecutionDependencyOnRelationshipCollection HasAnExecutionDependencyOn { get; set; } = new ProcessSegmentHasAnExecutionDependencyOnRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentHasAnExecutionDependencyOnSegmentRelationshipCollection HasAnExecutionDependencyOnSegment { get; set; } = new ProcessSegmentHasAnExecutionDependencyOnSegmentRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentContainsParameterRelationshipCollection ContainsParameter { get; set; } = new ProcessSegmentContainsParameterRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentContainsPersonnelSpecificationRelationshipCollection ContainsPersonnelSpecification { get; set; } = new ProcessSegmentContainsPersonnelSpecificationRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentContainsEquipmentSpecificationRelationshipCollection ContainsEquipmentSpecification { get; set; } = new ProcessSegmentContainsEquipmentSpecificationRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentContainsPhysicalAssetSpecificationRelationshipCollection ContainsPhysicalAssetSpecification { get; set; } = new ProcessSegmentContainsPhysicalAssetSpecificationRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentContainsMaterialSpecificationRelationshipCollection ContainsMaterialSpecification { get; set; } = new ProcessSegmentContainsMaterialSpecificationRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new ProcessSegmentHierarchyScopeRelRelationshipCollection();

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