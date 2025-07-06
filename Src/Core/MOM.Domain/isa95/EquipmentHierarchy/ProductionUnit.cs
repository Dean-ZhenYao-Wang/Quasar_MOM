namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class ProductionUnit : WorkCenter, IEquatable<ProductionUnit>
    {

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