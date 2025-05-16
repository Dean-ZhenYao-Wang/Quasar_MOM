using MOM.Domain.Permission;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    public partial class PersonnelClass
    {
        public string? Description { get; set; }
        /// <summary>
        /// 负责人DtId
        /// </summary>
        public Guid? ResponsibleDtId { get; set; }

        public PersonnelClass(string Id, string? description = null, HierarchyScope? hierarchyScope = null) : this()
        {
            this.Id = Id;
            this.Description = description;
            if (hierarchyScope != null)
            {
                this.HierarchyScope = hierarchyScope.Id;
                this.HierarchyScopeRel.Add(new Common.Relationship.isa95.PersonnelClass.PersonnelClassHierarchyScopeRelRelationship(this, hierarchyScope));
            }
        }

        public void Update(string ID, Guid? responsibleDtId)
        {
            this.Id = Id;
            this.ResponsibleDtId = responsibleDtId;
        }
        public void Delete()
        {
            foreach (var item in HasPropertiesOf)
            {
                item.Target.Delete();
            }
            this.HierarchyScopeRel.Clear();
            this.IncludesPropertiesOf.Clear();
            this.HasPropertiesOf.Clear();
            this.IsDelete = true;
        }
        public virtual List<Permission.PersonnelClassPermission> Permissions { get; set; }
    }
}