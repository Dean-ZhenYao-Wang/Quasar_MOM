namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.EquipmentProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class EquipmentProperty : ResourceProperty, IEquatable<EquipmentProperty>
    {
        public EquipmentProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentProperty;1";

        [JsonIgnore]
public virtual List<EquipmentPropertyContainsRelationship> Contains { get; set; } = new List<EquipmentPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<EquipmentPropertyMapsToRelationship> MapsTo { get; set; } = new List<EquipmentPropertyMapsToRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentProperty);
        }

        public bool Equals(EquipmentProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(EquipmentProperty? left, EquipmentProperty? right)
        {
            return EqualityComparer<EquipmentProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentProperty? left, EquipmentProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}