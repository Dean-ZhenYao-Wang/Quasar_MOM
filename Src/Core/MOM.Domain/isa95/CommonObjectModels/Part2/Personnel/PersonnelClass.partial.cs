using MOM.Domain.Permission;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    public partial class PersonnelClass
    {
        /// <summary>
        /// 说明-系统内部做业务区分使用的
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 备注-页面上显示给用户看的，用户自己编辑的备注信息
        /// </summary>
        public string? Remark { get; set; }

        /// <summary>
        /// 负责人DtId
        /// </summary>
        public Guid? ResponsibleDtId { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public virtual Person Responsible { get; set; }

        public PersonnelClass(string Id, string name, string? description = null, HierarchyScope? hierarchyScope = null) : this()
        {
            this.Id = Id;
            this.Name = name;
            this.Description = description;
            if (hierarchyScope != null)
            {
                this.HierarchyScopeRelDtId = hierarchyScope.DtId;
                this.HierarchyScopeRel = hierarchyScope;
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
            this.HierarchyScopeRelDtId = null;
            this.HierarchyScopeRel = null;
            this.IncludesPropertiesOf.Clear();
            this.HasPropertiesOf.Clear();
            this.IsDelete = true;
        }

        public virtual List<Permission.PersonnelClassPermission> Permissions { get; set; } = new List<PersonnelClassPermission>();
    }
}