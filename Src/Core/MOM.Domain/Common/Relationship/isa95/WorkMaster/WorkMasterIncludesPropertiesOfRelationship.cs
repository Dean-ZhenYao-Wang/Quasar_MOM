namespace MOM.Domain.Common.Relationship.isa95.WorkMaster
{
    public class WorkMasterIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>, IEquatable<WorkMasterIncludesPropertiesOfRelationship>
    {
        public WorkMasterIncludesPropertiesOfRelationship()
        {
            Name = "includesPropertiesOf";
        }

        public WorkMasterIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster source, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkMasterIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterIncludesPropertiesOfRelationship);
        }

        public bool Equals(WorkMasterIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkMasterIncludesPropertiesOfRelationship? left, WorkMasterIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<WorkMasterIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterIncludesPropertiesOfRelationship? left, WorkMasterIncludesPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkMasterIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}