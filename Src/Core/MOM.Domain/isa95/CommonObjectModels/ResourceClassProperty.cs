namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public abstract partial class ResourceClassProperty : BaseEntity, IEquatable<ResourceClassProperty>
    {
        public ResourceClassProperty() : base()
        {
        }


        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceClassProperty);
        }

        public bool Equals(ResourceClassProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ResourceClassProperty? left, ResourceClassProperty? right)
        {
            return EqualityComparer<ResourceClassProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceClassProperty? left, ResourceClassProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}