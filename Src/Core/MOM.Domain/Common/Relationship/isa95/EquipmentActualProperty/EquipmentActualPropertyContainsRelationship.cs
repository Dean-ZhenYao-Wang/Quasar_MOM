using System;

namespace MOM.Domain.Common.Relationship.isa95.EquipmentActualProperty
{
    public class EquipmentActualPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActualProperty>, IEquatable<EquipmentActualPropertyContainsRelationship>
    {
        public EquipmentActualPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public EquipmentActualPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActualProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActualProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentActualPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentActualPropertyContainsRelationship);
        }

        public bool Equals(EquipmentActualPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentActualPropertyContainsRelationship? left, EquipmentActualPropertyContainsRelationship? right)
        {
            return EqualityComparer<EquipmentActualPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentActualPropertyContainsRelationship? left, EquipmentActualPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentActualPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}