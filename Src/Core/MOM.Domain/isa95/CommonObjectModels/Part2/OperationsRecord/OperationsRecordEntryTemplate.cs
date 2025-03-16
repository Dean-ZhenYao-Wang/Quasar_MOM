namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsRecord
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationsRecordEntryTemplate;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsRecordEntryTemplate : BaseEntity, IEquatable<OperationsRecordEntryTemplate>
    {
        public OperationsRecordEntryTemplate()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsRecordEntryTemplate;1";

        [JsonPropertyName("informationObject")]
        public string? InformationObject { get; set; }

        [JsonPropertyName("informationObjectID")]
        public string? InformationObjectID { get; set; }

        [JsonPropertyName("informationObjectType")]
        public string? InformationObjectType { get; set; }

        [JsonPropertyName("effectiveTimestamp")]
        public DateTime? EffectiveTimestamp { get; set; }

        [JsonPropertyName("recordTimestamp")]
        public DateTime? RecordTimestamp { get; set; }

        [JsonIgnore]
        public virtual OperationsRecordEntryTemplateContainsRelationshipCollection Contains { get; set; } = new OperationsRecordEntryTemplateContainsRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationshipCollection CorrespondsToAnEntryIn { get; set; } = new OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationshipCollection CorrespondsToAnExternalEntryIn { get; set; } = new OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRecordEntryTemplate);
        }

        public bool Equals(OperationsRecordEntryTemplate? other)
        {
            return other is not null && base.Equals(other) && InformationObject == other.InformationObject && InformationObjectID == other.InformationObjectID && InformationObjectType == other.InformationObjectType && EffectiveTimestamp == other.EffectiveTimestamp && RecordTimestamp == other.RecordTimestamp;
        }

        public static bool operator ==(OperationsRecordEntryTemplate? left, OperationsRecordEntryTemplate? right)
        {
            return EqualityComparer<OperationsRecordEntryTemplate?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRecordEntryTemplate? left, OperationsRecordEntryTemplate? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), InformationObject?.GetHashCode(), InformationObjectID?.GetHashCode(), InformationObjectType?.GetHashCode(), EffectiveTimestamp?.GetHashCode(), RecordTimestamp?.GetHashCode());
        }
    }
}