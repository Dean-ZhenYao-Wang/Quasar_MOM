namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkRecord
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.WorkRecordSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkRecordSpecification : BaseEntity, IEquatable<WorkRecordSpecification>
    {
        public WorkRecordSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkRecordSpecification;1";

        [JsonPropertyName("informationObjectModel")]
        public string? InformationObjectModel { get; set; }

        [JsonPropertyName("informationObjectTypeMultiplicity")]
        public string? InformationObjectTypeMultiplicity { get; set; }

        [JsonPropertyName("action")]
        public WorkRecordSpecificationAction? Action { get; set; }

        [JsonPropertyName("actionMultiplicity")]
        public string? ActionMultiplicity { get; set; }

        [JsonIgnore]
public virtual List<WorkRecordSpecificationContainsRelationship> Contains { get; set; } = new List<WorkRecordSpecificationContainsRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRecordSpecification);
        }

        public bool Equals(WorkRecordSpecification? other)
        {
            return other is not null && base.Equals(other) && InformationObjectModel == other.InformationObjectModel && InformationObjectTypeMultiplicity == other.InformationObjectTypeMultiplicity && Action == other.Action && ActionMultiplicity == other.ActionMultiplicity;
        }

        public static bool operator ==(WorkRecordSpecification? left, WorkRecordSpecification? right)
        {
            return EqualityComparer<WorkRecordSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRecordSpecification? left, WorkRecordSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), InformationObjectModel?.GetHashCode(), InformationObjectTypeMultiplicity?.GetHashCode(), Action?.GetHashCode(), ActionMultiplicity?.GetHashCode());
        }
    }
}