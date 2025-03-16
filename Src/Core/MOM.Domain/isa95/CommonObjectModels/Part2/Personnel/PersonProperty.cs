namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PersonProperty;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public partial class PersonProperty : ResourceProperty, IEquatable<PersonProperty>
    {
        public PersonProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonProperty;1";

        //[JsonIgnore]
        public virtual PersonPropertyContainsRelationshipCollection Contains { get; set; } = new PersonPropertyContainsRelationshipCollection();
        [MaxLength(1)]
        //[JsonIgnore]
        public virtual PersonPropertyMapsToRelationshipCollection MapsTo { get; set; } = new PersonPropertyMapsToRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonProperty);
        }

        public bool Equals(PersonProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PersonProperty? left, PersonProperty? right)
        {
            return EqualityComparer<PersonProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonProperty? left, PersonProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}