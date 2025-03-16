namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsRecord
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsRecordTemplate;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsRecordTemplate : BaseEntity, IEquatable<OperationsRecordTemplate>
    {
        public OperationsRecordTemplate()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsRecordTemplate;1";

        [JsonPropertyName("action")]
        public OperationsRecordTemplateAction? Action { get; set; }

        [JsonPropertyName("effectiveTimestamp")]
        public DateTime? EffectiveTimestamp { get; set; }

        [JsonPropertyName("recordTimestamp")]
        public DateTime? RecordTimestamp { get; set; }

        [JsonIgnore]
        public virtual OperationsRecordTemplateRecordsActionOnRelationshipCollection RecordsActionOn { get; set; } = new OperationsRecordTemplateRecordsActionOnRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsRecordTemplateSpecifiedByRelationshipCollection SpecifiedBy { get; set; } = new OperationsRecordTemplateSpecifiedByRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsRecordTemplateContainsRelationshipCollection Contains { get; set; } = new OperationsRecordTemplateContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRecordTemplate);
        }

        public bool Equals(OperationsRecordTemplate? other)
        {
            return other is not null && base.Equals(other) && Action == other.Action && EffectiveTimestamp == other.EffectiveTimestamp && RecordTimestamp == other.RecordTimestamp;
        }

        public static bool operator ==(OperationsRecordTemplate? left, OperationsRecordTemplate? right)
        {
            return EqualityComparer<OperationsRecordTemplate?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRecordTemplate? left, OperationsRecordTemplate? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Action?.GetHashCode(), EffectiveTimestamp?.GetHashCode(), RecordTimestamp?.GetHashCode());
        }
    }
}