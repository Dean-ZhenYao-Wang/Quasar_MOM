namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsEvent
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationsEventClassRecordSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsEventClassRecordSpecification : BaseEntity, IEquatable<OperationsEventClassRecordSpecification>
    {
        public OperationsEventClassRecordSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsEventClassRecordSpecification;1";

        [JsonIgnore]
        public virtual OperationsEventClassRecordSpecificationContainsRelationshipCollection Contains { get; set; } = new OperationsEventClassRecordSpecificationContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventClassRecordSpecification);
        }

        public bool Equals(OperationsEventClassRecordSpecification? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OperationsEventClassRecordSpecification? left, OperationsEventClassRecordSpecification? right)
        {
            return EqualityComparer<OperationsEventClassRecordSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventClassRecordSpecification? left, OperationsEventClassRecordSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}