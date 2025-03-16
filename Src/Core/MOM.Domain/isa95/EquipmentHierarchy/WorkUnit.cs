namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class WorkUnit : SiteAsset, IEquatable<WorkUnit>
    {
        public WorkUnit()
        {
            EquipmentLevel = Common.EnumType.HierarchyScopeEquipmentLevel.Work_Unit;
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkUnit;1";

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkUnit);
        }

        public bool Equals(WorkUnit? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WorkUnit? left, WorkUnit? right)
        {
            return EqualityComparer<WorkUnit?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkUnit? left, WorkUnit? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}