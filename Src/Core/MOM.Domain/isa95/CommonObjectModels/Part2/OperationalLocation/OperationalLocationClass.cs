namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationalLocationClass;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationalLocationClass : BaseEntity, IEquatable<OperationalLocationClass>
    {
        public OperationalLocationClass()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationalLocationClass;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
        public virtual OperationalLocationClassIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new OperationalLocationClassIncludesPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual OperationalLocationClassIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new OperationalLocationClassIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual OperationalLocationClassHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new OperationalLocationClassHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual OperationalLocationClassHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new OperationalLocationClassHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationClass);
        }

        public bool Equals(OperationalLocationClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(OperationalLocationClass? left, OperationalLocationClass? right)
        {
            return EqualityComparer<OperationalLocationClass?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationClass? left, OperationalLocationClass? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}