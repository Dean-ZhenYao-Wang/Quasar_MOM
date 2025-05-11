using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.Area
{
    public class AreaWorkCenterRelationship : Relationship<Domain.isa95.EquipmentHierarchy.WorkCenter>, IEquatable<AreaWorkCenterRelationship>
    {
        public AreaWorkCenterRelationship()
        {
            Name = "workCenter";
        }

        [JsonIgnore]
        [ForeignKey(nameof(SourceId))]
        public virtual MOM.Domain.isa95.EquipmentHierarchy.Area Source { get; set; }

        public AreaWorkCenterRelationship(Domain.isa95.EquipmentHierarchy.Area source, Domain.isa95.EquipmentHierarchy.WorkCenter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public AreaWorkCenterRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as AreaWorkCenterRelationship);
        }

        public bool Equals(AreaWorkCenterRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(AreaWorkCenterRelationship? left, AreaWorkCenterRelationship? right)
        {
            return EqualityComparer<AreaWorkCenterRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(AreaWorkCenterRelationship? left, AreaWorkCenterRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as AreaWorkCenterRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}