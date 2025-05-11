namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirementProperty
{
    public class PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>, IEquatable<PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship>
    {
        public PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship? left, PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship? left, PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetRequirementPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}