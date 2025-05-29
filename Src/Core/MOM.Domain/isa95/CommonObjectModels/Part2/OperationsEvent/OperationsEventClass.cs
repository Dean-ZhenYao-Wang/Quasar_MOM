namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsEvent
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationsEventClass;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsEventClass : BaseEntity, IEquatable<OperationsEventClass>
    {
        public OperationsEventClass()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsEventClass;1";

        [JsonPropertyName("extension")]
        public string? Extension { get; set; }

        /// <summary>
        /// 组合关系
        /// </summary>
        [JsonIgnore]
public virtual List<OperationsEventClassIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<OperationsEventClassIsAssembledFromRelationship>();

        [JsonIgnore]
public virtual List<OperationsEventClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<OperationsEventClassIncludesPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<OperationsEventClassHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<OperationsEventClassHasPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<OperationsEventClassHasRecordSpecificationOfRelationship> HasRecordSpecificationOf { get; set; } = new List<OperationsEventClassHasRecordSpecificationOfRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventClass);
        }

        public bool Equals(OperationsEventClass? other)
        {
            return other is not null && base.Equals(other) && Extension == other.Extension;
        }

        public static bool operator ==(OperationsEventClass? left, OperationsEventClass? right)
        {
            return EqualityComparer<OperationsEventClass?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventClass? left, OperationsEventClass? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Extension?.GetHashCode());
        }
    }
}