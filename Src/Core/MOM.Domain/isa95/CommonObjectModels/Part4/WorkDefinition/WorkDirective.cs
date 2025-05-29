namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkDirective;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkDirective : WorkDefinition, IEquatable<WorkDirective>
    {
        public WorkDirective()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkDirective;1";

        [JsonIgnore]
public virtual List<WorkDirectiveIsCretaedFromRelationship> IsCretaedFrom { get; set; } = new List<WorkDirectiveIsCretaedFromRelationship>();

        [JsonIgnore]
public virtual List<WorkDirectiveContainsRelationship> Contains { get; set; } = new List<WorkDirectiveContainsRelationship>();

        [JsonIgnore]
public virtual List<WorkDirectiveHasARelationship> HasA { get; set; } = new List<WorkDirectiveHasARelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkDirective);
        }

        public bool Equals(WorkDirective? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WorkDirective? left, WorkDirective? right)
        {
            return EqualityComparer<WorkDirective?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkDirective? left, WorkDirective? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}