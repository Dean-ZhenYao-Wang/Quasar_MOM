namespace MOM.Domain.Common.Relationship.isa95.WorkCenter
{
    public partial class WorkCenterWorkUnitRelationship : Relationship<Domain.isa95.EquipmentHierarchy.WorkUnit>, IEquatable<WorkCenterWorkUnitRelationship>
    {
        public WorkCenterWorkUnitRelationship()
        {
            Name = "workUnit";
        }

        public WorkCenterWorkUnitRelationship(Domain.isa95.EquipmentHierarchy.WorkCenter source, Domain.isa95.EquipmentHierarchy.WorkUnit target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkCenterWorkUnitRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkCenterWorkUnitRelationship);
        }

        public bool Equals(WorkCenterWorkUnitRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkCenterWorkUnitRelationship? left, WorkCenterWorkUnitRelationship? right)
        {
            return EqualityComparer<WorkCenterWorkUnitRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkCenterWorkUnitRelationship? left, WorkCenterWorkUnitRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkCenterWorkUnitRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}