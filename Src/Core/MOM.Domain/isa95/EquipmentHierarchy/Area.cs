namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.Area;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class Area : SiteAsset, IEquatable<Area>
    {
        public Area()
        {
            this.EquipmentLevel = Common.EnumType.HierarchyScopeEquipmentLevel.Area;
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:Area;1";

        [JsonIgnore]
        public virtual AreaWorkCenterRelationshipCollection WorkCenter { get; set; } = new AreaWorkCenterRelationshipCollection();

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