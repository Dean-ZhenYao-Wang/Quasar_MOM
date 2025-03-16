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
        public virtual WorkDefinitionContainsParameterRelationshipCollection ContainsParameter { get; set; } = new WorkDefinitionContainsParameterRelationshipCollection();

        [JsonIgnore]
        public virtual WorkDefinitionContainsPersonnelRelationshipCollection ContainsPersonnel { get; set; } = new WorkDefinitionContainsPersonnelRelationshipCollection();

        [JsonIgnore]
        public virtual WorkDefinitionContainsEquipmentRelationshipCollection ContainsEquipment { get; set; } = new WorkDefinitionContainsEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual WorkDefinitionContainsPhysicalAssetRelationshipCollection ContainsPhysicalAsset { get; set; } = new WorkDefinitionContainsPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual WorkDefinitionContainsMaterialRelationshipCollection ContainsMaterial { get; set; } = new WorkDefinitionContainsMaterialRelationshipCollection();

        [JsonIgnore]
        public virtual WorkDefinitionHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new WorkDefinitionHierarchyScopeRelRelationshipCollection();

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