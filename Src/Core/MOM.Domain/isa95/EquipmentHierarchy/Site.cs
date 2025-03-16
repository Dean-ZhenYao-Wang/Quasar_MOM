namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.Site;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class Site : SiteAsset, IEquatable<Site>
    {
        public Site()
        {
            this.EquipmentLevel = Common.EnumType.HierarchyScopeEquipmentLevel.Site;
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:Site;1";

        [JsonIgnore]
        public virtual SiteAreaRelationshipCollection Area { get; set; } = new SiteAreaRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as Site);
        }

        public bool Equals(Site? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Site? left, Site? right)
        {
            return EqualityComparer<Site?>.Default.Equals(left, right);
        }

        public static bool operator !=(Site? left, Site? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}