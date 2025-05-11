namespace MOM.Domain.Common.Relationship.isa95.MaterialClass
{
    public class MaterialClassIsAssembledFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>, IEquatable<MaterialClassIsAssembledFromRelationship>
    {
        public MaterialClassIsAssembledFromRelationship()
        {
            Name = "IsAssembledFrom";
        }

        public MaterialClassIsAssembledFromRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialClassIsAssembledFromRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialClassIsAssembledFromRelationship);
        }

        public bool Equals(MaterialClassIsAssembledFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialClassIsAssembledFromRelationship? left, MaterialClassIsAssembledFromRelationship? right)
        {
            return EqualityComparer<MaterialClassIsAssembledFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialClassIsAssembledFromRelationship? left, MaterialClassIsAssembledFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialClassIsAssembledFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}