namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotStorageLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<MaterialSublotStorageLocationRelRelationship>
    {
        public MaterialSublotStorageLocationRelRelationship()
        {
            Name = "storageLocationRel";
        }

        public MaterialSublotStorageLocationRelRelationship(MOM.Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSublotStorageLocationRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSublotStorageLocationRelRelationship);
        }

        public bool Equals(MaterialSublotStorageLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSublotStorageLocationRelRelationship? left, MaterialSublotStorageLocationRelRelationship? right)
        {
            return EqualityComparer<MaterialSublotStorageLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSublotStorageLocationRelRelationship? left, MaterialSublotStorageLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSublotStorageLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}