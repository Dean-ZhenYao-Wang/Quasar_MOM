namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsTest
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.EvaluatedProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EvaluatedProperty : BaseEntity, IEquatable<EvaluatedProperty>
    {
        public EvaluatedProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EvaluatedProperty;1";

        [JsonIgnore]
        public virtual EvaluatedPropertyCorrespondsToRelationshipCollection CorrespondsTo { get; set; } = new EvaluatedPropertyCorrespondsToRelationshipCollection();

        [JsonIgnore]
        public virtual EvaluatedPropertyMeasuredWithMethodOfRelationshipCollection MeasuredWithMethodOf { get; set; } = new EvaluatedPropertyMeasuredWithMethodOfRelationshipCollection();

        [JsonIgnore]
        public virtual EvaluatedPropertyReferencesRelationshipCollection References { get; set; } = new EvaluatedPropertyReferencesRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EvaluatedProperty);
        }

        public bool Equals(EvaluatedProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(EvaluatedProperty? left, EvaluatedProperty? right)
        {
            return EqualityComparer<EvaluatedProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(EvaluatedProperty? left, EvaluatedProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}