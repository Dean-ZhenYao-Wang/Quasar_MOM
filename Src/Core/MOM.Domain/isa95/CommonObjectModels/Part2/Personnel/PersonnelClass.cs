namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using MOM.Domain.Permission;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    public partial class PersonnelClass : ResourceClass, IEquatable<PersonnelClass>
    {
        public PersonnelClass()
        {
        }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get { return HierarchyScopeRel?.FullPath; } }

        [JsonIgnore]
        public virtual List<PersonnelClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<PersonnelClassIncludesPropertiesOfRelationship>();
        /// <summary>
        /// ��չ����
        /// </summary>
        public PersonnelClassProperty Property { get; set; } = new PersonnelClassProperty();

        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }
        public Guid? HierarchyScopeRelDtId { get; set; }
        /// <summary>
        /// ˵��-ϵͳ�ڲ���ҵ������ʹ�õ�
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ��ע-ҳ������ʾ���û����ģ��û��Լ��༭�ı�ע��Ϣ
        /// </summary>
        public string? Remark { get; set; }

        /// <summary>
        /// ������DtId
        /// </summary>
        public Guid? ResponsibleDtId { get; set; }

        /// <summary>
        /// ������
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
            this.HierarchyScopeRelDtId = null;
            this.HierarchyScopeRel = null;
            this.IncludesPropertiesOf.Clear();
            this.IsDelete = true;
        }

        public virtual List<Permission.PersonnelClassPermission> Permissions { get; set; } = new List<PersonnelClassPermission>();

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
            return this.IncludesPropertiesOf.Where(m => m.Target.IsDelete == false).Select(m => m.DtId).ToList();
        }

        public void IncludesPropertiesOfAddTarget(Guid targetDtId)
        {
            this.IncludesPropertiesOf.Add(new PersonnelClassIncludesPropertiesOfRelationship(this.DtId, targetDtId));
        }

        public void IncludesPropertiesOfRemoveTargets(IEnumerable<Guid> deleteDtIds)
        {
            this.IncludesPropertiesOf.RemoveAll(m => deleteDtIds.Contains(m.TargetId));
        }


        public void IncludesPropertiesOfAddTarget(PersonnelClass target)
        {
            this.IncludesPropertiesOf.Add(new PersonnelClassIncludesPropertiesOfRelationship(this, target));
        }
    }
}