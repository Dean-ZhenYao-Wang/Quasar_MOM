namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecificationProperty>, IEquatable<MaterialCapabilityHasValuesOfRelationship>
    {
        public MaterialCapabilityHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public MaterialCapabilityHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialCapabilityHasValuesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapabilityHasValuesOfRelationship);
        }

        public bool Equals(MaterialCapabilityHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialCapabilityHasValuesOfRelationship? left, MaterialCapabilityHasValuesOfRelationship? right)
        {
            return EqualityComparer<MaterialCapabilityHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapabilityHasValuesOfRelationship? left, MaterialCapabilityHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialCapabilityHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}