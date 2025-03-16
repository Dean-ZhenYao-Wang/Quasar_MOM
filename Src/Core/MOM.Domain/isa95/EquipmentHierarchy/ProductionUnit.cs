namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class ProductionUnit : WorkCenter, IEquatable<ProductionUnit>
    {
        public ProductionUnit()
        {
            EquipmentLevel = Common.EnumType.HierarchyScopeEquipmentLevel.Production_Unit;
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ProductionUnit;1";

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProductionUnit);
        }

        public bool Equals(ProductionUnit? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ProductionUnit? left, ProductionUnit? right)
        {
            return EqualityComparer<ProductionUnit?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProductionUnit? left, ProductionUnit? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}