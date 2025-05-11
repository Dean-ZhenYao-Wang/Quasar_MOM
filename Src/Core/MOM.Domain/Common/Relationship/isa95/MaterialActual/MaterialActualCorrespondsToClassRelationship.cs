namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualCorrespondsToClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>, IEquatable<MaterialActualCorrespondsToClassRelationship>
    {
        public MaterialActualCorrespondsToClassRelationship()
        {
            Name = "correspondsToClass";
        }

        public MaterialActualCorrespondsToClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialActualCorrespondsToClassRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActualCorrespondsToClassRelationship);
        }

        public bool Equals(MaterialActualCorrespondsToClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialActualCorrespondsToClassRelationship? left, MaterialActualCorrespondsToClassRelationship? right)
        {
            return EqualityComparer<MaterialActualCorrespondsToClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActualCorrespondsToClassRelationship? left, MaterialActualCorrespondsToClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialActualCorrespondsToClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}