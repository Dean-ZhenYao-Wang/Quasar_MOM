namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.WorkflowSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkflowSpecification : BaseEntity, IEquatable<WorkflowSpecification>
    {
        public WorkflowSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkflowSpecification;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("definitionType")]
        public WorkflowSpecificationDefinitionType? DefinitionType { get; set; }

        [JsonIgnore]
        public virtual WorkflowSpecificationIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new WorkflowSpecificationIncludesPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationIsACollectionOfNodeRelationshipCollection IsACollectionOfNode { get; set; } = new WorkflowSpecificationIsACollectionOfNodeRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationIsACollectionOfConnectionRelationshipCollection IsACollectionOfConnection { get; set; } = new WorkflowSpecificationIsACollectionOfConnectionRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new WorkflowSpecificationHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new WorkflowSpecificationHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecification);
        }

        public bool Equals(WorkflowSpecification? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && DefinitionType == other.DefinitionType;
        }

        public static bool operator ==(WorkflowSpecification? left, WorkflowSpecification? right)
        {
            return EqualityComparer<WorkflowSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecification? left, WorkflowSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), DefinitionType?.GetHashCode());
        }
    }
}