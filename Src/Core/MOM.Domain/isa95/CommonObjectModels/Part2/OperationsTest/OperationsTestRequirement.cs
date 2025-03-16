namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsTest
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationsTestRequirement;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsTestRequirement : BaseEntity, IEquatable<OperationsTestRequirement>
    {
        public OperationsTestRequirement()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsTestRequirement;1";

        [JsonIgnore]
        public virtual OperationsTestRequirementSpecifiesRelationshipCollection Specifies { get; set; } = new OperationsTestRequirementSpecifiesRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsTestRequirementCorrespondsToAnElementInRelationshipCollection CorrespondsToAnElementIn { get; set; } = new OperationsTestRequirementCorrespondsToAnElementInRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsTestRequirementMapsToAPropertyElementInRelationshipCollection MapsToAPropertyElementIn { get; set; } = new OperationsTestRequirementMapsToAPropertyElementInRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsTestRequirement);
        }

        public bool Equals(OperationsTestRequirement? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OperationsTestRequirement? left, OperationsTestRequirement? right)
        {
            return EqualityComparer<OperationsTestRequirement?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsTestRequirement? left, OperationsTestRequirement? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}