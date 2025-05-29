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

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
public virtual List<OperationalLocationClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<OperationalLocationClassIncludesPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<OperationalLocationClassIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<OperationalLocationClassIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<OperationalLocationClassHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<OperationalLocationClassHasPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<OperationalLocationClassHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<OperationalLocationClassHierarchyScopeRelRelationship>();

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