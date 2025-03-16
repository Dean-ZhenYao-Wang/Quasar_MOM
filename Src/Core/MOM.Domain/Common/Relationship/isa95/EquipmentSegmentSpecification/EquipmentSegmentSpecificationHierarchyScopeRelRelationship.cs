namespace MOM.Domain.Common.Relationship.isa95.EquipmentSegmentSpecification
{
    public class EquipmentSegmentSpecificationHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<EquipmentSegmentSpecificationHierarchyScopeRelRelationship>
    {
        public EquipmentSegmentSpecificationHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public EquipmentSegmentSpecificationHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.EquipmentSegmentSpecification source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentSegmentSpecificationHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentSegmentSpecificationHierarchyScopeRelRelationship);
        }

        public bool Equals(EquipmentSegmentSpecificationHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentSegmentSpecificationHierarchyScopeRelRelationship? left, EquipmentSegmentSpecificationHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<EquipmentSegmentSpecificationHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentSegmentSpecificationHierarchyScopeRelRelationship? left, EquipmentSegmentSpecificationHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentSegmentSpecificationHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}