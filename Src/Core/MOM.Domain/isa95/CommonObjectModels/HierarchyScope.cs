namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class HierarchyScope : BaseEntity, IEquatable<MOM.Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public HierarchyScope() : base()
        {
        }

        [JsonPropertyName("equipmentID")]
        public string? EquipmentID { get; set; }

        [JsonPropertyName("equipmentLevel")]
        public HierarchyScopeEquipmentLevel EquipmentLevel { get; set; }

        [JsonIgnore]
public virtual List<HierarchyScopeContainsRelationship> Contains { get; set; } = new List<HierarchyScopeContainsRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as HierarchyScope);
        }

        public bool Equals(HierarchyScope? other)
        {
            return other is not null && base.Equals(other) && EquipmentID == other.EquipmentID && EquipmentLevel == other.EquipmentLevel;
        }

        public static bool operator ==(HierarchyScope? left, HierarchyScope? right)
        {
            return EqualityComparer<HierarchyScope?>.Default.Equals(left, right);
        }

        public static bool operator !=(HierarchyScope? left, HierarchyScope? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), EquipmentID?.GetHashCode(), EquipmentLevel.GetHashCode());
        }
    }
}