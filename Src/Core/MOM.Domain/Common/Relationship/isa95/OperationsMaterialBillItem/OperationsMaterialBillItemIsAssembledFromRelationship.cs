namespace MOM.Domain.Common.Relationship.isa95.OperationsMaterialBillItem
{
    public class OperationsMaterialBillItemIsAssembledFromRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBillItem>, IEquatable<OperationsMaterialBillItemIsAssembledFromRelationship>
    {
        public OperationsMaterialBillItemIsAssembledFromRelationship()
        {
            Name = "isAssembledFrom";
        }

        public OperationsMaterialBillItemIsAssembledFromRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBillItem source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBillItem target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsMaterialBillItemIsAssembledFromRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsMaterialBillItemIsAssembledFromRelationship);
        }

        public bool Equals(OperationsMaterialBillItemIsAssembledFromRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsMaterialBillItemIsAssembledFromRelationship? left, OperationsMaterialBillItemIsAssembledFromRelationship? right)
        {
            return EqualityComparer<OperationsMaterialBillItemIsAssembledFromRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsMaterialBillItemIsAssembledFromRelationship? left, OperationsMaterialBillItemIsAssembledFromRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsMaterialBillItemIsAssembledFromRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}