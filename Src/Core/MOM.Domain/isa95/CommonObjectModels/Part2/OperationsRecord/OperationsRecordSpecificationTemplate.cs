namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsRecord
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsRecordSpecificationTemplate;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsRecordSpecificationTemplate : BaseEntity, IEquatable<OperationsRecordSpecificationTemplate>
    {
        public OperationsRecordSpecificationTemplate()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsRecordSpecificationTemplate;1";

        [JsonPropertyName("informationObjectType")]
        public string? InformationObjectType { get; set; }

        [JsonPropertyName("informationObjectTypeMultiplicity")]
        public string? InformationObjectTypeMultiplicity { get; set; }

        [JsonPropertyName("action")]
        public OperationsRecordSpecificationTemplateAction? Action { get; set; }

        [JsonPropertyName("ationMultiplicity")]
        public string? AtionMultiplicity { get; set; }

        [JsonIgnore]
        public virtual OperationsRecordSpecificationTemplateContainsRelationshipCollection Contains { get; set; } = new OperationsRecordSpecificationTemplateContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRecordSpecificationTemplate);
        }

        public bool Equals(OperationsRecordSpecificationTemplate? other)
        {
            return other is not null && base.Equals(other) && InformationObjectType == other.InformationObjectType && InformationObjectTypeMultiplicity == other.InformationObjectTypeMultiplicity && Action == other.Action && AtionMultiplicity == other.AtionMultiplicity;
        }

        public static bool operator ==(OperationsRecordSpecificationTemplate? left, OperationsRecordSpecificationTemplate? right)
        {
            return EqualityComparer<OperationsRecordSpecificationTemplate?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRecordSpecificationTemplate? left, OperationsRecordSpecificationTemplate? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), InformationObjectType?.GetHashCode(), InformationObjectTypeMultiplicity?.GetHashCode(), Action?.GetHashCode(), AtionMultiplicity?.GetHashCode());
        }
    }
}