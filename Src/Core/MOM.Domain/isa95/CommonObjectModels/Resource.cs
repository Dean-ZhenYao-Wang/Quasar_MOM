namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public abstract class Resource : BaseEntity, IEquatable<Resource>
    {
        public Resource() : base()
        {
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Resource);
        }

        public bool Equals(Resource? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Resource? left, Resource? right)
        {
            return EqualityComparer<Resource?>.Default.Equals(left, right);
        }

        public static bool operator !=(Resource? left, Resource? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}