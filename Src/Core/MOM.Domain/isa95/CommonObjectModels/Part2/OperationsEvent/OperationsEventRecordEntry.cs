namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsEvent
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationsEventRecordEntry;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsEventRecordEntry : BaseEntity, IEquatable<OperationsEventRecordEntry>
    {
        public OperationsEventRecordEntry()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsEventRecordEntry;1";

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
        public virtual OperationsEventRecordEntryContainsRelationshipCollection Contains { get; set; } = new OperationsEventRecordEntryContainsRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsEventRecordEntryCorrespondsToAnEntryInRelationshipCollection CorrespondsToAnEntryIn { get; set; } = new OperationsEventRecordEntryCorrespondsToAnEntryInRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationshipCollection CorrespondsToAnExternalEntryIn { get; set; } = new OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventRecordEntry);
        }

        public bool Equals(OperationsEventRecordEntry? other)
        {
            return other is not null && base.Equals(other) && InformationObject == other.InformationObject && InformationObjectID == other.InformationObjectID && InformationObjectType == other.InformationObjectType && EffectiveTimestamp == other.EffectiveTimestamp && RecordTimestamp == other.RecordTimestamp;
        }

        public static bool operator ==(OperationsEventRecordEntry? left, OperationsEventRecordEntry? right)
        {
            return EqualityComparer<OperationsEventRecordEntry?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventRecordEntry? left, OperationsEventRecordEntry? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), InformationObject?.GetHashCode(), InformationObjectID?.GetHashCode(), InformationObjectType?.GetHashCode(), EffectiveTimestamp?.GetHashCode(), RecordTimestamp?.GetHashCode());
        }
    }
}