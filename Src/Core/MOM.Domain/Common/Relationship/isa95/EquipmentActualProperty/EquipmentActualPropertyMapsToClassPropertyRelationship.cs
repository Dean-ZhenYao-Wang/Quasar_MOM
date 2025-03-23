namespace MOM.Domain.Common.Relationship.isa95.EquipmentActualProperty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class EquipmentActualPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty>, IEquatable<EquipmentActualPropertyMapsToClassPropertyRelationship>
    {
        public EquipmentActualPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public EquipmentActualPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActualProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentActualPropertyMapsToClassPropertyRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentActualPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(EquipmentActualPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentActualPropertyMapsToClassPropertyRelationship? left, EquipmentActualPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<EquipmentActualPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentActualPropertyMapsToClassPropertyRelationship? left, EquipmentActualPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentActualPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}