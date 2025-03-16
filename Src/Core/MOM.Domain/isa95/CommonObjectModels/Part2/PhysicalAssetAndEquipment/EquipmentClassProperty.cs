namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.EquipmentClassProperty;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class EquipmentClassProperty : ResourceClassProperty, IEquatable<EquipmentClassProperty>
    {
        public EquipmentClassProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentClassProperty;1";

        [JsonIgnore]
        public virtual EquipmentClassPropertyContainsRelationshipCollection Contains { get; set; } = new EquipmentClassPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClassProperty);
        }

        public bool Equals(EquipmentClassProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(EquipmentClassProperty? left, EquipmentClassProperty? right)
        {
            return EqualityComparer<EquipmentClassProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentClassProperty? left, EquipmentClassProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}