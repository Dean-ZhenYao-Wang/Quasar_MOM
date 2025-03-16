namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkRecord
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkRecord;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkRecord : BaseEntity, IEquatable<WorkRecord>
    {
        public WorkRecord()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkRecord;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("creationDate")]
        public DateTime? CreationDate { get; set; }

        [JsonPropertyName("lastChangedDate")]
        public DateTime? LastChangedDate { get; set; }

        [JsonPropertyName("changeIndication")]
        public string? ChangeIndication { get; set; }

        [JsonPropertyName("recordStatus")]
        public string? RecordStatus { get; set; }

        [JsonPropertyName("expiration")]
        public DateTime? Expiration { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("campaignID")]
        public string? CampaignID { get; set; }

        [JsonPropertyName("lotID")]
        public string? LotID { get; set; }

        [JsonPropertyName("batchID")]
        public string? BatchID { get; set; }

        [JsonPropertyName("materialDefinitionID")]
        public string? MaterialDefinitionID { get; set; }

        [JsonPropertyName("equipmentID")]
        public string? EquipmentID { get; set; }

        [JsonPropertyName("delimiter")]
        public string? Delimiter { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonIgnore]
        public virtual WorkRecordDefinedByRelationshipCollection DefinedBy { get; set; } = new WorkRecordDefinedByRelationshipCollection();

        [JsonIgnore]
        public virtual WorkRecordContainsRelationshipCollection Contains { get; set; } = new WorkRecordContainsRelationshipCollection();

        [JsonIgnore]
        public virtual WorkRecordRecordsActionOnRelationshipCollection RecordsActionOn { get; set; } = new WorkRecordRecordsActionOnRelationshipCollection();

        [JsonIgnore]
        public virtual WorkRecordHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new WorkRecordHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRecord);
        }

        public bool Equals(WorkRecord? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && CreationDate == other.CreationDate && LastChangedDate == other.LastChangedDate && ChangeIndication == other.ChangeIndication && RecordStatus == other.RecordStatus && Expiration == other.Expiration && Version == other.Version && CampaignID == other.CampaignID && LotID == other.LotID && BatchID == other.BatchID && MaterialDefinitionID == other.MaterialDefinitionID && EquipmentID == other.EquipmentID && Delimiter == other.Delimiter && Language == other.Language;
        }

        public static bool operator ==(WorkRecord? left, WorkRecord? right)
        {
            return EqualityComparer<WorkRecord?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRecord? left, WorkRecord? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), CreationDate?.GetHashCode(), LastChangedDate?.GetHashCode(), ChangeIndication?.GetHashCode(), RecordStatus?.GetHashCode(), Expiration?.GetHashCode(), Version?.GetHashCode(), CampaignID?.GetHashCode(), LotID?.GetHashCode(), BatchID?.GetHashCode(), MaterialDefinitionID?.GetHashCode(), EquipmentID?.GetHashCode(), Delimiter?.GetHashCode(), Language?.GetHashCode());
        }
    }
}