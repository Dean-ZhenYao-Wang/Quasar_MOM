namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class Unit : WorkUnit, IEquatable<Unit>
    {
        public override bool Equals(object? obj)
        {
            return Equals(obj as Unit);
        }

        public bool Equals(Unit? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Unit? left, Unit? right)
        {
            return EqualityComparer<Unit?>.Default.Equals(left, right);
        }

        public static bool operator !=(Unit? left, Unit? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}