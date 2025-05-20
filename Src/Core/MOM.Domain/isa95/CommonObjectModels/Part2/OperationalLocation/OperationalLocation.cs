namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.OperationalLocation;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationalLocation : Resource, IEquatable<OperationalLocation>
    {
        public OperationalLocation()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationalLocation;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
        public virtual OperationalLocationDefinedByRelationshipCollection DefinedBy { get; set; } = new OperationalLocationDefinedByRelationshipCollection();

        [JsonIgnore]
        public virtual OperationalLocationHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new OperationalLocationHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual OperationalLocationIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new OperationalLocationIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual OperationalLocationHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new OperationalLocationHierarchyScopeRelRelationshipCollection();
        /// <summary>
        /// 在空间上将设备定义为零维点、一维线、二维形状或三维实体。
        /// </summary>
        [JsonIgnore]
        public SpatialDefinition SpatialDefinition { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocation);
        }

        public bool Equals(OperationalLocation? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(OperationalLocation? left, OperationalLocation? right)
        {
            return EqualityComparer<OperationalLocation?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocation? left, OperationalLocation? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}