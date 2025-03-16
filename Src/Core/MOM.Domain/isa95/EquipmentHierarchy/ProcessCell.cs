namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class ProcessCell : WorkCenter, IEquatable<ProcessCell>
    {
        public ProcessCell()
        {
            EquipmentLevel = Common.EnumType.HierarchyScopeEquipmentLevel.Process_Cell;
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ProcessCell;1";

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