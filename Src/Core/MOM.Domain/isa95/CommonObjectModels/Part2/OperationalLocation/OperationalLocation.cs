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

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
        public virtual List<OperationalLocationDefinedByRelationship> DefinedBy { get; set; } = new List<OperationalLocationDefinedByRelationship>();

        [JsonIgnore]
        public virtual List<OperationalLocationHasValuesOfRelationship> HasValuesOf { get; set; } = new List<OperationalLocationHasValuesOfRelationship>();

        [JsonIgnore]
        public virtual List<OperationalLocationIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<OperationalLocationIsMadeUpOfRelationship>();

        [JsonIgnore]
        public virtual List<OperationalLocationHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<OperationalLocationHierarchyScopeRelRelationship>();
        /// <summary>
        /// �ڿռ��Ͻ��豸����Ϊ��ά�㡢һά�ߡ���ά��״����άʵ�塣
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