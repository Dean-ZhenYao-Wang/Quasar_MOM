namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetClassProperty;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetClassProperty : ResourceClassProperty, IEquatable<PhysicalAssetClassProperty>
    {
        public PhysicalAssetClassProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetClassProperty;1";

        [JsonIgnore]
        public virtual PhysicalAssetClassPropertyContainsRelationshipCollection Contains { get; set; } = new PhysicalAssetClassPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetClassProperty);
        }

        public bool Equals(PhysicalAssetClassProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PhysicalAssetClassProperty? left, PhysicalAssetClassProperty? right)
        {
            return EqualityComparer<PhysicalAssetClassProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetClassProperty? left, PhysicalAssetClassProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}