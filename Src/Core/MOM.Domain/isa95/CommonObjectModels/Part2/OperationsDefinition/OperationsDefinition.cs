namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsDefinition;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class OperationsDefinition : Resource, IEquatable<OperationsDefinition>
    {
        public OperationsDefinition()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsDefinition;1";

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("operationsType")]
        public OperationsDefinitionOperationsType? OperationsType { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("definitionType")]
        public OperationsDefinitionDefinitionType? DefinitionType { get; set; }

        [JsonIgnore]
public virtual List<OperationsDefinitionContainsRelationship> Contains { get; set; } = new List<OperationsDefinitionContainsRelationship>();

        [JsonIgnore]
public virtual List<OperationsDefinitionIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<OperationsDefinitionIncludesPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<OperationsDefinitionHasAssociatedRelationship> HasAssociated { get; set; } = new List<OperationsDefinitionHasAssociatedRelationship>();

        [JsonIgnore]
public virtual List<OperationsDefinitionHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<OperationsDefinitionHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsDefinition);
        }

        public bool Equals(OperationsDefinition? other)
        {
            return other is not null && base.Equals(other) && Version == other.Version && OperationsType == other.OperationsType && HierarchyScope == other.HierarchyScope && DefinitionType == other.DefinitionType;
        }

        public static bool operator ==(OperationsDefinition? left, OperationsDefinition? right)
        {
            return EqualityComparer<OperationsDefinition?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsDefinition? left, OperationsDefinition? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Version?.GetHashCode(), OperationsType?.GetHashCode(), HierarchyScope?.GetHashCode(), DefinitionType?.GetHashCode());
        }
    }
}