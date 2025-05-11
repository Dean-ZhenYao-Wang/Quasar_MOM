namespace MOM.Domain.Common.Relationship.isa95.MaterialDefinition
{
    public class MaterialDefinitionIsAssembledFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>, IEquatable<MaterialDefinitionIsAssembledFromRelationship>
    {
        public MaterialDefinitionIsAssembledFromRelationship()
        {
            Name = "isAssembledFrom";
        }

        public MaterialDefinitionIsAssembledFromRelationship(Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition source, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialDefinitionIsAssembledFromRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialDefinitionIsAssembledFromRelationship);
        }

        public bool Equals(MaterialDefinitionIsAssembledFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialDefinitionIsAssembledFromRelationship? left, MaterialDefinitionIsAssembledFromRelationship? right)
        {
            return EqualityComparer<MaterialDefinitionIsAssembledFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialDefinitionIsAssembledFromRelationship? left, MaterialDefinitionIsAssembledFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialDefinitionIsAssembledFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}