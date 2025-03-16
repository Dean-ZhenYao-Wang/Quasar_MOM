namespace MOM.Domain.Common.Relationship.isa95.OperationsMaterialBillItem
{
    public class OperationsMaterialBillItemIsUseOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification>, IEquatable<OperationsMaterialBillItemIsUseOfRelationship>
    {
        public OperationsMaterialBillItemIsUseOfRelationship()
        {
            Name = "isUseOf";
        }

        public OperationsMaterialBillItemIsUseOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBillItem source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsMaterialBillItemIsUseOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsMaterialBillItemIsUseOfRelationship);
        }

        public bool Equals(OperationsMaterialBillItemIsUseOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsMaterialBillItemIsUseOfRelationship? left, OperationsMaterialBillItemIsUseOfRelationship? right)
        {
            return EqualityComparer<OperationsMaterialBillItemIsUseOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsMaterialBillItemIsUseOfRelationship? left, OperationsMaterialBillItemIsUseOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsMaterialBillItemIsUseOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}