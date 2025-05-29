namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionType;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkflowSpecificationConnectionType : BaseEntity, IEquatable<WorkflowSpecificationConnectionType>
    {
        public WorkflowSpecificationConnectionType()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkflowSpecificationConnectionType;1";

        [JsonPropertyName("fromMultiplicity")]
        public string? FromMultiplicity { get; set; }

        [JsonPropertyName("toMultiplicity")]
        public string? ToMultiplicity { get; set; }

        [JsonIgnore]
public virtual List<WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<WorkflowSpecificationConnectionTypeHasPropertiesOfRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionType);
        }

        public bool Equals(WorkflowSpecificationConnectionType? other)
        {
            return other is not null && base.Equals(other) && FromMultiplicity == other.FromMultiplicity && ToMultiplicity == other.ToMultiplicity;
        }

        public static bool operator ==(WorkflowSpecificationConnectionType? left, WorkflowSpecificationConnectionType? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionType?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionType? left, WorkflowSpecificationConnectionType? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), FromMultiplicity?.GetHashCode(), ToMultiplicity?.GetHashCode());
        }
    }
}