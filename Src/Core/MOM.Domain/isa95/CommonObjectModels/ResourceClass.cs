namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public abstract class ResourceClass : BaseEntity, IEquatable<ResourceClass>
    {
        public ResourceClass() : base()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ResourceClass;1";

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceClass);
        }

        public bool Equals(ResourceClass? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ResourceClass? left, ResourceClass? right)
        {
            return EqualityComparer<ResourceClass?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceClass? left, ResourceClass? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}