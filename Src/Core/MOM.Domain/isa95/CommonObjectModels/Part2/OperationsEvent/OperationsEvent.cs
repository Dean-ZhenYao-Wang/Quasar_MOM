namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsEvent
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsEvent;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsEvent : BaseEntity, IEquatable<OperationsEvent>
    {
        public OperationsEvent()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsEvent;1";

        [JsonPropertyName("effectiveTimestamp")]
        public DateTime? EffectiveTimestamp { get; set; }

        [JsonPropertyName("recordTimestamp")]
        public DateTime? RecordTimestamp { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("priority")]
        public string? Priority { get; set; }

        [JsonPropertyName("operationsEventType")]
        public OperationsEventOperationsEventType? OperationsEventType { get; set; }

        [JsonPropertyName("operationsEventLevel")]
        public OperationsEventOperationsEventLevel? OperationsEventLevel { get; set; }

        [JsonPropertyName("operationsType")]
        public OperationsEventOperationsType? OperationsType { get; set; }

        [JsonPropertyName("momFunction")]
        public OperationsEventMomFunction? MomFunction { get; set; }

        [JsonPropertyName("enterpriseFunction")]
        public OperationsEventEnterpriseFunction? EnterpriseFunction { get; set; }

        [JsonPropertyName("category")]
        public string? Category { get; set; }

        [JsonPropertyName("source")]
        public string? Source { get; set; }

        [JsonIgnore]
        public virtual OperationsEventIsACollectionOfRelationshipCollection IsACollectionOf { get; set; } = new OperationsEventIsACollectionOfRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsEventHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new OperationsEventHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsEventDefinedByRelationshipCollection DefinedBy { get; set; } = new OperationsEventDefinedByRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsEventIsMadeOfRelationshipCollection IsMadeOf { get; set; } = new OperationsEventIsMadeOfRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsEventHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new OperationsEventHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEvent);
        }

        public bool Equals(OperationsEvent? other)
        {
            return other is not null && base.Equals(other) && EffectiveTimestamp == other.EffectiveTimestamp && RecordTimestamp == other.RecordTimestamp && HierarchyScope == other.HierarchyScope && Priority == other.Priority && OperationsEventType == other.OperationsEventType && OperationsEventLevel == other.OperationsEventLevel && OperationsType == other.OperationsType && MomFunction == other.MomFunction && EnterpriseFunction == other.EnterpriseFunction && Category == other.Category && Source == other.Source;
        }

        public static bool operator ==(OperationsEvent? left, OperationsEvent? right)
        {
            return EqualityComparer<OperationsEvent?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEvent? left, OperationsEvent? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), EffectiveTimestamp?.GetHashCode(), RecordTimestamp?.GetHashCode(), HierarchyScope?.GetHashCode(), Priority?.GetHashCode(), OperationsEventType?.GetHashCode(), OperationsEventLevel?.GetHashCode(), OperationsType?.GetHashCode(), MomFunction?.GetHashCode(), EnterpriseFunction?.GetHashCode(), Category?.GetHashCode(), Source?.GetHashCode());
        }
    }
}