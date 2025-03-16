namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class StorageZone : WorkCenter, IEquatable<StorageZone>
    {
        public StorageZone()
        {
            EquipmentLevel = Common.EnumType.HierarchyScopeEquipmentLevel.Storage_Zone;
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:StorageZone;1";

        public override bool Equals(object? obj)
        {
            return Equals(obj as StorageZone);
        }

        public bool Equals(StorageZone? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StorageZone? left, StorageZone? right)
        {
            return EqualityComparer<StorageZone?>.Default.Equals(left, right);
        }

        public static bool operator !=(StorageZone? left, StorageZone? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}