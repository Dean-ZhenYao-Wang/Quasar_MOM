namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using Microsoft.AspNetCore.Mvc;
    using MOM.Domain.Common;
    //using MOM.Domain.Common.Relationship.isa95.Enterprise;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;
    [Table(nameof(Enterprise))]
    public partial class Enterprise : SiteAsset, IEquatable<Enterprise>
    {
        public Enterprise(string id, string name, string? description = null, bool active = false, string? address = null, Guid? responsibleDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Enterprise,id, name, address, description, active)
        {
            this.ResponsibleDtId = responsibleDtId;
        }

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