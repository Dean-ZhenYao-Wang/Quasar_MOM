namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionContainsPersonnelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification>, IEquatable<WorkDefinitionContainsPersonnelRelationship>
    {
        public WorkDefinitionContainsPersonnelRelationship()
        {
            Name = "containsPersonnel";
        }

        public WorkDefinitionContainsPersonnelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkDefinitionContainsPersonnelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkDefinitionContainsPersonnelRelationship);
        }

        public bool Equals(WorkDefinitionContainsPersonnelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkDefinitionContainsPersonnelRelationship? left, WorkDefinitionContainsPersonnelRelationship? right)
        {
            return EqualityComparer<WorkDefinitionContainsPersonnelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkDefinitionContainsPersonnelRelationship? left, WorkDefinitionContainsPersonnelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkDefinitionContainsPersonnelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}