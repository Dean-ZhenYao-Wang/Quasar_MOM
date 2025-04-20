namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.Enterprise;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class Enterprise : SiteAsset, IEquatable<Enterprise>
    {
        public Enterprise()
        {
            this.EquipmentLevel = Common.EnumType.HierarchyScopeEquipmentLevel.Enterprise;
        }


        [JsonIgnore]
        public virtual EnterpriseSiteRelationshipCollection Site { get; set; } = new EnterpriseSiteRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as Enterprise);
        }

        public bool Equals(Enterprise? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Enterprise? left, Enterprise? right)
        {
            return EqualityComparer<Enterprise?>.Default.Equals(left, right);
        }

        public static bool operator !=(Enterprise? left, Enterprise? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}