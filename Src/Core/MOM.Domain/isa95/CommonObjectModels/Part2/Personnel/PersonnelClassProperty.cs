namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PersonnelClassProperty;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class PersonnelClassProperty : ResourceClassProperty, IEquatable<PersonnelClassProperty>
    {
        public PersonnelClassProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PersonnelClassProperty;1";

        [JsonIgnore]
        public virtual PersonnelClassPropertyContainsRelationshipCollection Contains { get; set; } = new PersonnelClassPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelClassProperty);
        }

        public bool Equals(PersonnelClassProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PersonnelClassProperty? left, PersonnelClassProperty? right)
        {
            return EqualityComparer<PersonnelClassProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelClassProperty? left, PersonnelClassProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}