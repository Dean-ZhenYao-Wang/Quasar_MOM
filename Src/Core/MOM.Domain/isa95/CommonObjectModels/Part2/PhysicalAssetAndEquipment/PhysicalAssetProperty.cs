namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetProperty : ResourceProperty, IEquatable<PhysicalAssetProperty>
    {
        public PhysicalAssetProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetProperty;1";

        [JsonIgnore]
public virtual List<PhysicalAssetPropertyContainsRelationship> Contains { get; set; } = new List<PhysicalAssetPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetPropertyMapsToRelationship> MapsTo { get; set; } = new List<PhysicalAssetPropertyMapsToRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetProperty);
        }

        public bool Equals(PhysicalAssetProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PhysicalAssetProperty? left, PhysicalAssetProperty? right)
        {
            return EqualityComparer<PhysicalAssetProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetProperty? left, PhysicalAssetProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}