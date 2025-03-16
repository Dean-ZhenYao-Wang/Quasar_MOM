namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualCorrespondsToSublotRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>, IEquatable<MaterialActualCorrespondsToSublotRelationship>
    {
        public MaterialActualCorrespondsToSublotRelationship()
        {
            Name = "correspondsToSublot";
        }

        public MaterialActualCorrespondsToSublotRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialActualCorrespondsToSublotRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActualCorrespondsToSublotRelationship);
        }

        public bool Equals(MaterialActualCorrespondsToSublotRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialActualCorrespondsToSublotRelationship? left, MaterialActualCorrespondsToSublotRelationship? right)
        {
            return EqualityComparer<MaterialActualCorrespondsToSublotRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActualCorrespondsToSublotRelationship? left, MaterialActualCorrespondsToSublotRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialActualCorrespondsToSublotRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}