namespace MOM.Domain.Common.Relationship.isa95.OperationsMaterialBill
{
    public class OperationsMaterialBillIsACollectionOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBillItem>, IEquatable<OperationsMaterialBillIsACollectionOfRelationship>
    {
        public OperationsMaterialBillIsACollectionOfRelationship()
        {
            Name = "isACollectionOf";
        }

        public OperationsMaterialBillIsACollectionOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBill source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBillItem target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsMaterialBillIsACollectionOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsMaterialBillIsACollectionOfRelationship);
        }

        public bool Equals(OperationsMaterialBillIsACollectionOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsMaterialBillIsACollectionOfRelationship? left, OperationsMaterialBillIsACollectionOfRelationship? right)
        {
            return EqualityComparer<OperationsMaterialBillIsACollectionOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsMaterialBillIsACollectionOfRelationship? left, OperationsMaterialBillIsACollectionOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsMaterialBillIsACollectionOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}