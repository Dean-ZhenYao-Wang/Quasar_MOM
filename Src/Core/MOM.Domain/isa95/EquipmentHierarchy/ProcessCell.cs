namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class ProcessCell : WorkCenter, IEquatable<ProcessCell>
    {
        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessCell);
        }

        public bool Equals(ProcessCell? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ProcessCell? left, ProcessCell? right)
        {
            return EqualityComparer<ProcessCell?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessCell? left, ProcessCell? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}