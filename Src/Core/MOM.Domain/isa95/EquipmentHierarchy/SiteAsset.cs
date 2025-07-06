namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public abstract partial class SiteAsset : HierarchyScope, IEquatable<SiteAsset>
    {
        public SiteAsset(HierarchyScopeEquipmentLevel equipmentLevel, string ID, string name, string? address = null, string? description = null, bool active = false) : base(equipmentLevel, ID, name, address, active, description)
        {
        }
        public override bool Equals(object? obj)
        {
            return Equals(obj as SiteAsset);
        }

        public bool Equals(SiteAsset? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SiteAsset? left, SiteAsset? right)
        {
            return EqualityComparer<SiteAsset?>.Default.Equals(left, right);
        }

        public static bool operator !=(SiteAsset? left, SiteAsset? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}