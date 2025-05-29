namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotIsAssembledFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot ,Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>, IEquatable<MaterialSublotIsAssembledFromRelationship>
    {
        public MaterialSublotIsAssembledFromRelationship()
        {
            Name = "isAssembledFrom";
        }

        public MaterialSublotIsAssembledFromRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialSublotIsAssembledFromRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSublotIsAssembledFromRelationship);
        }

        public bool Equals(MaterialSublotIsAssembledFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialSublotIsAssembledFromRelationship? left, MaterialSublotIsAssembledFromRelationship? right)
        {
            return EqualityComparer<MaterialSublotIsAssembledFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSublotIsAssembledFromRelationship? left, MaterialSublotIsAssembledFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialSublotIsAssembledFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}