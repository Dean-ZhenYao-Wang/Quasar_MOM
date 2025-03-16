namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkRecord
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkRecordEntry;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkRecordEntry : BaseEntity, IEquatable<WorkRecordEntry>
    {
        public WorkRecordEntry()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkRecordEntry;1";

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
        public virtual WorkRecordEntryContainsRelationshipCollection Contains { get; set; } = new WorkRecordEntryContainsRelationshipCollection();

        [JsonIgnore]
        public virtual WorkRecordEntryCorrespondsToAnEntryInRelationshipCollection CorrespondsToAnEntryIn { get; set; } = new WorkRecordEntryCorrespondsToAnEntryInRelationshipCollection();

        [JsonIgnore]
        public virtual WorkRecordEntryCorrespondsToAnExternalEntryInRelationshipCollection CorrespondsToAnExternalEntryIn { get; set; } = new WorkRecordEntryCorrespondsToAnExternalEntryInRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRecordEntry);
        }

        public bool Equals(WorkRecordEntry? other)
        {
            return other is not null && base.Equals(other) && InformationObject == other.InformationObject && InformationObjectID == other.InformationObjectID && InformationObjectType == other.InformationObjectType && EffectiveTimestamp == other.EffectiveTimestamp && RecordTimestamp == other.RecordTimestamp;
        }

        public static bool operator ==(WorkRecordEntry? left, WorkRecordEntry? right)
        {
            return EqualityComparer<WorkRecordEntry?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRecordEntry? left, WorkRecordEntry? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), InformationObject?.GetHashCode(), InformationObjectID?.GetHashCode(), InformationObjectType?.GetHashCode(), EffectiveTimestamp?.GetHashCode(), RecordTimestamp?.GetHashCode());
        }
    }
}