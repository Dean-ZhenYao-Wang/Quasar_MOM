namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class WorkCell : WorkUnit, IEquatable<WorkCell>
    {
        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCell);
        }

        public bool Equals(WorkCell? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WorkCell? left, WorkCell? right)
        {
            return EqualityComparer<WorkCell?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCell? left, WorkCell? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}