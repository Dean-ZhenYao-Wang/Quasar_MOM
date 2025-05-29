namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClass
{
    public class OperationalLocationClassHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass,Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClassProperty>, IEquatable<OperationalLocationClassHasPropertiesOfRelationship>
    {
        public OperationalLocationClassHasPropertiesOfRelationship():base()
        {
            Name = "hasPropertiesOf";
        }
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationClassHasPropertiesOfRelationship);
        }

        public bool Equals(OperationalLocationClassHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationalLocationClassHasPropertiesOfRelationship? left, OperationalLocationClassHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<OperationalLocationClassHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationClassHasPropertiesOfRelationship? left, OperationalLocationClassHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationalLocationClassHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}