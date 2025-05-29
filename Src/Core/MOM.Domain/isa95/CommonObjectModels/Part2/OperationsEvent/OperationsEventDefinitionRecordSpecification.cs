namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsEvent
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationsEventDefinitionRecordSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsEventDefinitionRecordSpecification : BaseEntity, IEquatable<OperationsEventDefinitionRecordSpecification>
    {
        public OperationsEventDefinitionRecordSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsEventDefinitionRecordSpecification;1";

        [JsonIgnore]
public virtual List<OperationsEventDefinitionRecordSpecificationMapsToRelationship> MapsTo { get; set; } = new List<OperationsEventDefinitionRecordSpecificationMapsToRelationship>();

        [JsonIgnore]
public virtual List<OperationsEventDefinitionRecordSpecificationContainsRelationship> Contains { get; set; } = new List<OperationsEventDefinitionRecordSpecificationContainsRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventDefinitionRecordSpecification);
        }

        public bool Equals(OperationsEventDefinitionRecordSpecification? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OperationsEventDefinitionRecordSpecification? left, OperationsEventDefinitionRecordSpecification? right)
        {
            return EqualityComparer<OperationsEventDefinitionRecordSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventDefinitionRecordSpecification? left, OperationsEventDefinitionRecordSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}