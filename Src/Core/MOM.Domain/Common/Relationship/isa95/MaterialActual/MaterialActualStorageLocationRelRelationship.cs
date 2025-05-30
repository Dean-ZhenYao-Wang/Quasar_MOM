namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualStorageLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual,Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<MaterialActualStorageLocationRelRelationship>
    {
        public MaterialActualStorageLocationRelRelationship()
        {
            Name = "storageLocationRel";
        }

        public MaterialActualStorageLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialActualStorageLocationRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialActualStorageLocationRelRelationship);
        }

        public bool Equals(MaterialActualStorageLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialActualStorageLocationRelRelationship? left, MaterialActualStorageLocationRelRelationship? right)
        {
            return EqualityComparer<MaterialActualStorageLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialActualStorageLocationRelRelationship? left, MaterialActualStorageLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialActualStorageLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}