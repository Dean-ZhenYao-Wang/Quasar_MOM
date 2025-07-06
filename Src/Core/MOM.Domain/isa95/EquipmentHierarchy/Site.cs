namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    //using MOM.Domain.Common.Relationship.isa95.Site;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    [Table(nameof(Site))]
    public partial class Site : SiteAsset, IEquatable<Site>
    {
        //[JsonIgnore]
        //public virtual SiteAreaRelationshipCollection Area { get; set; } = new SiteAreaRelationshipCollection();


        public Site(string id, string name, string description = "", bool active = false, string address = "", Guid? responsibleDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Site,id, name, address, description, active)
        {
            this.ResponsibleDtId = responsibleDtId;
        }
        public Enterprise Enterprise=>GetParent<Enterprise>();
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