namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class StorageUnit : WorkUnit, IEquatable<StorageUnit>
    {
        public StorageUnit()
        {
            EquipmentLevel = Common.EnumType.HierarchyScopeEquipmentLevel.Storage_Unit;
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:StorageUnit;1";

        public override bool Equals(object? obj)
        {
            return Equals(obj as StorageUnit);
        }

        public bool Equals(StorageUnit? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StorageUnit? left, StorageUnit? right)
        {
            return EqualityComparer<StorageUnit?>.Default.Equals(left, right);
        }

        public static bool operator !=(StorageUnit? left, StorageUnit? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}