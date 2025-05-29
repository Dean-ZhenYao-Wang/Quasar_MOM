using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.PersonnelClass
{
    public class PersonnelClassHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass ,Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PersonnelClassHierarchyScopeRelRelationship>
    {
        public PersonnelClassHierarchyScopeRelRelationship():base()
        {
            Name = "hierarchyScopeRel";
        }


        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelClassHierarchyScopeRelRelationship);
        }

        public bool Equals(PersonnelClassHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelClassHierarchyScopeRelRelationship? left, PersonnelClassHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PersonnelClassHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelClassHierarchyScopeRelRelationship? left, PersonnelClassHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelClassHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}