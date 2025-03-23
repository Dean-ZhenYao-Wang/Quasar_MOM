namespace MOM.Domain.Common.Relationship.isa95.MaterialDefinition
{
    public class MaterialDefinitionIsMemberOfClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>, IEquatable<MaterialDefinitionIsMemberOfClassRelationship>
    {
        public MaterialDefinitionIsMemberOfClassRelationship()
        {
            Name = "isMemberOfClass";
        }

        public MaterialDefinitionIsMemberOfClassRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialDefinitionIsMemberOfClassRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialDefinitionIsMemberOfClassRelationship);
        }

        public bool Equals(MaterialDefinitionIsMemberOfClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialDefinitionIsMemberOfClassRelationship? left, MaterialDefinitionIsMemberOfClassRelationship? right)
        {
            return EqualityComparer<MaterialDefinitionIsMemberOfClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialDefinitionIsMemberOfClassRelationship? left, MaterialDefinitionIsMemberOfClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialDefinitionIsMemberOfClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}