namespace MOM.Domain.isa95.EquipmentHierarchy
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkCenter;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class WorkCenter : SiteAsset, IEquatable<WorkCenter>
    {
        public WorkCenter()
        {
            EquipmentLevel = Common.EnumType.HierarchyScopeEquipmentLevel.Work_Center;
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkCenter;1";

        [JsonIgnore]
        public virtual WorkCenterWorkUnitRelationshipCollection WorkUnit { get; set; } = new WorkCenterWorkUnitRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCenter);
        }

        public bool Equals(WorkCenter? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WorkCenter? left, WorkCenter? right)
        {
            return EqualityComparer<WorkCenter?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCenter? left, WorkCenter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}