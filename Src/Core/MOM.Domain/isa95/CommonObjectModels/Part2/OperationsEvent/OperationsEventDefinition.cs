namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsEvent
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsEventDefinition;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsEventDefinition : BaseEntity, IEquatable<OperationsEventDefinition>
    {
        public OperationsEventDefinition()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsEventDefinition;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("priority")]
        public string? Priority { get; set; }

        [JsonPropertyName("operationsEventType")]
        public OperationsEventDefinitionOperationsEventType? OperationsEventType { get; set; }

        [JsonPropertyName("operationsEventLevel")]
        public OperationsEventDefinitionOperationsEventLevel? OperationsEventLevel { get; set; }

        [JsonPropertyName("operationsType")]
        public OperationsEventDefinitionOperationsType? OperationsType { get; set; }

        [JsonPropertyName("momFunction")]
        public OperationsEventDefinitionMomFunction? MomFunction { get; set; }

        [JsonPropertyName("enterpriseFunction")]
        public OperationsEventDefinitionEnterpriseFunction? EnterpriseFunction { get; set; }

        [JsonPropertyName("category")]
        public string? Category { get; set; }

        [JsonPropertyName("source")]
        public string? Source { get; set; }

        [JsonPropertyName("acknowledgment")]
        public string? Acknowledgment { get; set; }

        /// <summary>
        /// ��Ϲ�ϵ
        /// </summary>
        [JsonIgnore]
public virtual List<OperationsEventDefinitionIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<OperationsEventDefinitionIsAssembledFromRelationship>();

        [JsonIgnore]
public virtual List<OperationsEventDefinitionIsAMemberOfRelationship> IsAMemberOf { get; set; } = new List<OperationsEventDefinitionIsAMemberOfRelationship>();

        [JsonIgnore]
public virtual List<OperationsEventDefinitionHasRecordSpecificationsOfRelationship> HasRecordSpecificationsOf { get; set; } = new List<OperationsEventDefinitionHasRecordSpecificationsOfRelationship>();

        [JsonIgnore]
public virtual List<OperationsEventDefinitionHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<OperationsEventDefinitionHasPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<OperationsEventDefinitionHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<OperationsEventDefinitionHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinition);
        }

        public bool Equals(OperationsEventDefinition? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && Priority == other.Priority && OperationsEventType == other.OperationsEventType && OperationsEventLevel == other.OperationsEventLevel && OperationsType == other.OperationsType && MomFunction == other.MomFunction && EnterpriseFunction == other.EnterpriseFunction && Category == other.Category && Source == other.Source && Acknowledgment == other.Acknowledgment;
        }

        public static bool operator ==(OperationsEventDefinition? left, OperationsEventDefinition? right)
        {
            return EqualityComparer<OperationsEventDefinition?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinition? left, OperationsEventDefinition? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), Priority?.GetHashCode(), OperationsEventType?.GetHashCode(), OperationsEventLevel?.GetHashCode(), OperationsType?.GetHashCode(), MomFunction?.GetHashCode(), EnterpriseFunction?.GetHashCode(), Category?.GetHashCode(), Source?.GetHashCode(), Acknowledgment?.GetHashCode());
        }
    }
}