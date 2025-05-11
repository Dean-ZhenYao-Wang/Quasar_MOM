namespace MOM.Domain.Common.Relationship.isa95.EquipmentActualProperty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class EquipmentActualPropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty>, IEquatable<EquipmentActualPropertyMapsToPropertyRelationship>
    {
        public EquipmentActualPropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public EquipmentActualPropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActualProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentActualPropertyMapsToPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentActualPropertyMapsToPropertyRelationship);
        }

        public bool Equals(EquipmentActualPropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentActualPropertyMapsToPropertyRelationship? left, EquipmentActualPropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<EquipmentActualPropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentActualPropertyMapsToPropertyRelationship? left, EquipmentActualPropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentActualPropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}