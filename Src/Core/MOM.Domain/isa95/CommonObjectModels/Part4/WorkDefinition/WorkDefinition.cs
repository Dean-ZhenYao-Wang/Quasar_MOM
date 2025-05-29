namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.WorkDefinition;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkDefinition : Resource, IEquatable<WorkDefinition>
    {
        public WorkDefinition()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkDefinition;1";

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("workType")]
        public WorkDefinitionWorkType? WorkType { get; set; }

        [JsonPropertyName("duration")]
        public string? Duration { get; set; }

        [JsonPropertyName("durationUnitOfMeasure")]
        public string? DurationUnitOfMeasure { get; set; }

        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }

        [JsonIgnore]
public virtual List<WorkDefinitionContainsParameterRelationship> ContainsParameter { get; set; } = new List<WorkDefinitionContainsParameterRelationship>();

        [JsonIgnore]
public virtual List<WorkDefinitionContainsPersonnelRelationship> ContainsPersonnel { get; set; } = new List<WorkDefinitionContainsPersonnelRelationship>();

        [JsonIgnore]
public virtual List<WorkDefinitionContainsEquipmentRelationship> ContainsEquipment { get; set; } = new List<WorkDefinitionContainsEquipmentRelationship>();

        [JsonIgnore]
public virtual List<WorkDefinitionContainsPhysicalAssetRelationship> ContainsPhysicalAsset { get; set; } = new List<WorkDefinitionContainsPhysicalAssetRelationship>();

        [JsonIgnore]
public virtual List<WorkDefinitionContainsMaterialRelationship> ContainsMaterial { get; set; } = new List<WorkDefinitionContainsMaterialRelationship>();

        [JsonIgnore]
public virtual List<WorkDefinitionHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<WorkDefinitionHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkDefinition);
        }

        public bool Equals(WorkDefinition? other)
        {
            return other is not null && base.Equals(other) && Version == other.Version && HierarchyScope == other.HierarchyScope && WorkType == other.WorkType && Duration == other.Duration && DurationUnitOfMeasure == other.DurationUnitOfMeasure && PublishedDate == other.PublishedDate;
        }

        public static bool operator ==(WorkDefinition? left, WorkDefinition? right)
        {
            return EqualityComparer<WorkDefinition?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkDefinition? left, WorkDefinition? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Version?.GetHashCode(), HierarchyScope?.GetHashCode(), WorkType?.GetHashCode(), Duration?.GetHashCode(), DurationUnitOfMeasure?.GetHashCode(), PublishedDate?.GetHashCode());
        }
    }
}