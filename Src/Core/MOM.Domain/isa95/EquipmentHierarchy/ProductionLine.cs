namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class ProductionLine : WorkCenter, IEquatable<ProductionLine>
    {
        public override bool Equals(object? obj)
        {
            return Equals(obj as ProductionLine);
        }

        public bool Equals(ProductionLine? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ProductionLine? left, ProductionLine? right)
        {
            return EqualityComparer<ProductionLine?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProductionLine? left, ProductionLine? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}