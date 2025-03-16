namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsEvent
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsEventRecord;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsEventRecord : BaseEntity, IEquatable<OperationsEventRecord>
    {
        public OperationsEventRecord()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsEventRecord;1";

        [JsonPropertyName("action")]
        public OperationsEventRecordAction? Action { get; set; }

        [JsonPropertyName("effectiveTimestamp")]
        public DateTime? EffectiveTimestamp { get; set; }

        [JsonPropertyName("recordTimestamp")]
        public DateTime? RecordTimestamp { get; set; }

        [JsonIgnore]
        public virtual OperationsEventRecordRecordsActionOnRelationshipCollection RecordsActionOn { get; set; } = new OperationsEventRecordRecordsActionOnRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsEventRecordSpecifiedByRelationshipCollection SpecifiedBy { get; set; } = new OperationsEventRecordSpecifiedByRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsEventRecordContainsRelationshipCollection Contains { get; set; } = new OperationsEventRecordContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventRecord);
        }

        public bool Equals(OperationsEventRecord? other)
        {
            return other is not null && base.Equals(other) && Action == other.Action && EffectiveTimestamp == other.EffectiveTimestamp && RecordTimestamp == other.RecordTimestamp;
        }

        public static bool operator ==(OperationsEventRecord? left, OperationsEventRecord? right)
        {
            return EqualityComparer<OperationsEventRecord?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventRecord? left, OperationsEventRecord? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Action?.GetHashCode(), EffectiveTimestamp?.GetHashCode(), RecordTimestamp?.GetHashCode());
        }
    }
}