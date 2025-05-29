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
public virtual List<EvaluatedPropertyCorrespondsToRelationship> CorrespondsTo { get; set; } = new List<EvaluatedPropertyCorrespondsToRelationship>();

        [JsonIgnore]
public virtual List<EvaluatedPropertyMeasuredWithMethodOfRelationship> MeasuredWithMethodOf { get; set; } = new List<EvaluatedPropertyMeasuredWithMethodOfRelationship>();

        [JsonIgnore]
public virtual List<EvaluatedPropertyReferencesRelationship> References { get; set; } = new List<EvaluatedPropertyReferencesRelationship>();

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