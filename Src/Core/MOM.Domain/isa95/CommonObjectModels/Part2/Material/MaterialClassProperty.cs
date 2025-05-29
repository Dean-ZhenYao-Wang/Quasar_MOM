namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.MaterialClassProperty;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialClassProperty : ResourceClassProperty, IEquatable<MaterialClassProperty>
    {
        public MaterialClassProperty() : base()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialClassProperty;1";

        [JsonIgnore]
public virtual List<MaterialClassPropertyContainsRelationship> Contains { get; set; } = new List<MaterialClassPropertyContainsRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialClassProperty);
        }

        public bool Equals(MaterialClassProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MaterialClassProperty? left, MaterialClassProperty? right)
        {
            return EqualityComparer<MaterialClassProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialClassProperty? left, MaterialClassProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}