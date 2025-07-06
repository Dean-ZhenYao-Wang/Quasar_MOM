namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;

    public partial class WorkCenter : SiteAsset, IEquatable<WorkCenter>
    {
        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCenter);
        }

        public bool Equals(WorkCenter? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WorkCenter? left, WorkCenter? right)
        {
            return EqualityComparer<WorkCenter?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCenter? left, WorkCenter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}