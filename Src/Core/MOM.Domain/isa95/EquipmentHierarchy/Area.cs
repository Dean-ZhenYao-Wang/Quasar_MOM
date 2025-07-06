namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;

    public partial class Area : SiteAsset, IEquatable<Area>
    {
        public override bool Equals(object? obj)
        {
            return Equals(obj as Area);
        }

        public bool Equals(Area? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Area? left, Area? right)
        {
            return EqualityComparer<Area?>.Default.Equals(left, right);
        }

        public static bool operator !=(Area? left, Area? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}