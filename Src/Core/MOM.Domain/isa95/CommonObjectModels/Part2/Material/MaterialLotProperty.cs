namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.MaterialLotProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialLotProperty : ResourceProperty, IEquatable<MaterialLotProperty>
    {
        public MaterialLotProperty() : base()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialLotProperty;1";

        [JsonIgnore]
        public virtual MaterialLotPropertyContainsRelationshipCollection Contains { get; set; } = new MaterialLotPropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialLotPropertyMapsToRelationshipCollection MapsTo { get; set; } = new MaterialLotPropertyMapsToRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialLotProperty);
        }

        public bool Equals(MaterialLotProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MaterialLotProperty? left, MaterialLotProperty? right)
        {
            return EqualityComparer<MaterialLotProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialLotProperty? left, MaterialLotProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}