namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNodeType;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkflowSpecificationNodeType : BaseEntity, IEquatable<WorkflowSpecificationNodeType>
    {
        public WorkflowSpecificationNodeType()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkflowSpecificationNodeType;1";

        [JsonIgnore]
        public virtual WorkflowSpecificationNodeTypeHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new WorkflowSpecificationNodeTypeHasPropertiesOfRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeType);
        }

        public bool Equals(WorkflowSpecificationNodeType? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WorkflowSpecificationNodeType? left, WorkflowSpecificationNodeType? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeType?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeType? left, WorkflowSpecificationNodeType? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}