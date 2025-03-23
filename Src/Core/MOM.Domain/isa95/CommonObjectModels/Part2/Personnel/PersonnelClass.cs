namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public partial class PersonnelClass : ResourceClass, IEquatable<PersonnelClass>
    {
        public PersonnelClass()
        {
        }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
        public virtual PersonnelClassIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new PersonnelClassIncludesPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PersonnelClassHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new PersonnelClassHasPropertiesOfRelationshipCollection();
        [MaxLength(1)]
        [JsonIgnore]
        public virtual PersonnelClassHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PersonnelClassHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelClass);
        }

        public bool Equals(PersonnelClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(PersonnelClass? left, PersonnelClass? right)
        {
            return EqualityComparer<PersonnelClass?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelClass? left, PersonnelClass? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }

        public List<Guid> GetHaveChildClassDtIdList()
        {
            return this.IncludesPropertiesOf.Targets.Where(m => m.IsDelete == false).Select(m => m.DtId).ToList();
        }

        public void IncludesPropertiesOfAddTarget(Guid targetDtId)
        {
            this.IncludesPropertiesOf.Add(new PersonnelClassIncludesPropertiesOfRelationship(this.DtId, targetDtId));
        }

        public void IncludesPropertiesOfRemoveTargets(IEnumerable<string> deleteDtIds)
        {
            this.IncludesPropertiesOf.Remove(deleteDtIds);
        }

        public void HasPropertiesOfAddTarget(PersonnelClassProperty personnelClassProperty)
        {
            this.HasPropertiesOf.Add(new PersonnelClassHasPropertiesOfRelationship(this, personnelClassProperty));
        }

        public void IncludesPropertiesOfAddTarget(PersonnelClass target)
        {
            this.IncludesPropertiesOf.Add(new PersonnelClassIncludesPropertiesOfRelationship(this, target));
        }

        public void Update(string ID, string? description)
        {
            this.Id = Id;
            this.Description = description;
        }
    }
}