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
public virtual List<WorkMasterIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<WorkMasterIncludesPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<WorkMasterCorrespondsToProcessRelationship> CorrespondsToProcess { get; set; } = new List<WorkMasterCorrespondsToProcessRelationship>();

        [JsonIgnore]
public virtual List<WorkMasterCorrespondsToDefinitionRelationship> CorrespondsToDefinition { get; set; } = new List<WorkMasterCorrespondsToDefinitionRelationship>();

        [JsonIgnore]
public virtual List<WorkMasterCorrespondsToOperationsRelationship> CorrespondsToOperations { get; set; } = new List<WorkMasterCorrespondsToOperationsRelationship>();

        [JsonIgnore]
public virtual List<WorkMasterHasARelationship> HasA { get; set; } = new List<WorkMasterHasARelationship>();

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