namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationalLocationProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationalLocationProperty : ResourceProperty, IEquatable<OperationalLocationProperty>
    {
        public OperationalLocationProperty()
        {
        }

        [JsonIgnore]
public virtual List<OperationalLocationPropertyContainsRelationship> Contains { get; set; } = new List<OperationalLocationPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<OperationalLocationPropertyMapsToRelationship> MapsTo { get; set; } = new List<OperationalLocationPropertyMapsToRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationProperty);
        }

        public bool Equals(OperationalLocationProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OperationalLocationProperty? left, OperationalLocationProperty? right)
        {
            return EqualityComparer<OperationalLocationProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationProperty? left, OperationalLocationProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}