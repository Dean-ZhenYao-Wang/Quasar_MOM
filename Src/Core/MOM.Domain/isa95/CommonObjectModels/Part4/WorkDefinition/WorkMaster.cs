namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.WorkMaster;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkMaster : WorkDefinition, IEquatable<WorkMaster>
    {
        public WorkMaster()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkMaster;1";

        [JsonPropertyName("definitionType")]
        public WorkMasterDefinitionType? DefinitionType { get; set; }

        [JsonIgnore]
        public virtual WorkMasterIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new WorkMasterIncludesPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual WorkMasterCorrespondsToProcessRelationshipCollection CorrespondsToProcess { get; set; } = new WorkMasterCorrespondsToProcessRelationshipCollection();

        [JsonIgnore]
        public virtual WorkMasterCorrespondsToDefinitionRelationshipCollection CorrespondsToDefinition { get; set; } = new WorkMasterCorrespondsToDefinitionRelationshipCollection();

        [JsonIgnore]
        public virtual WorkMasterCorrespondsToOperationsRelationshipCollection CorrespondsToOperations { get; set; } = new WorkMasterCorrespondsToOperationsRelationshipCollection();

        [JsonIgnore]
        public virtual WorkMasterHasARelationshipCollection HasA { get; set; } = new WorkMasterHasARelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMaster);
        }

        public bool Equals(WorkMaster? other)
        {
            return other is not null && base.Equals(other) && DefinitionType == other.DefinitionType;
        }

        public static bool operator ==(WorkMaster? left, WorkMaster? right)
        {
            return EqualityComparer<WorkMaster?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMaster? left, WorkMaster? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), DefinitionType?.GetHashCode());
        }
    }
}