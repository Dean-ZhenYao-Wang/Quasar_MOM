namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsTest
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.ResourceActual;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ResourceActual : BaseEntity, IEquatable<ResourceActual>
    {
        public ResourceActual()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ResourceActual;1";

        [JsonIgnore]
public virtual List<ResourceActualReportsRelationship> Reports { get; set; } = new List<ResourceActualReportsRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceActual);
        }

        public bool Equals(ResourceActual? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ResourceActual? left, ResourceActual? right)
        {
            return EqualityComparer<ResourceActual?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceActual? left, ResourceActual? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}