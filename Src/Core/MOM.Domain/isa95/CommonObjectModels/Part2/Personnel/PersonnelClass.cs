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
    /// <summary>
    /// 人员类别
    /// </summary>
    /// <remarks>
    /// <para>表示具有相似特性的人员分组，用于特定目的（如制造运营定义、调度、能力和性能），应表示为人员类别。</para>
    /// <para>任何人员可能是零个或多个人员类别的成员。</para>
    /// <para>人员类别可定义为零个或多个人员类别的特化。</para>
    /// <para>人员类别可由零个或多个人员类别组成</para>
    /// </remarks>
    public partial class PersonnelClass : ResourceClass, IEquatable<PersonnelClass>
    {
        private PersonnelClass() { }
        /// <summary>
        /// 此人员类别包含目标人员类别的属性
        /// </summary>
        [JsonIgnore]
        public virtual List<PersonnelClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<PersonnelClassIncludesPropertiesOfRelationship>();
        /// <summary>
        /// 此人员类别具有的人员类别属性
        /// </summary>
        public PersonnelClassProperty Property { get; set; } = new PersonnelClassProperty();
        /// <summary>
        /// 人员类别的补充信息和描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 层级范围
        /// </summary>
        /// <remarks>
        /// 标识交换信息在基于角色的设备层级中的位置。可选地，层级范围可定义物理资产类别的范围（如定义的站点或区域）
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        public Guid? HierarchyScopeRelDtId { get; set; }
        /// <summary>
        /// 层级范围
        /// </summary>
        /// <remarks>
        /// 标识交换信息在基于角色的设备层级中的位置。可选地，层级范围可定义物理资产类别的范围（如定义的站点或区域）
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }
        /// <summary>
        /// 适配层级范围
        /// </summary>
        /// <remarks>
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }





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

        /// <summary>
        /// 权限清单，可访问的菜单按钮清单
        /// </summary>
        public virtual List<Permission.PersonnelClassPermission> Permissions { get; set; } = new List<PersonnelClassPermission>();


        public PersonnelClass(string Id, string name, string? description = null, HierarchyScope? hierarchyScope = null) 
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

        public override void Delete()
        {
            this.HierarchyScopeRelDtId = null;
            this.HierarchyScopeRel = null;
            this.IncludesPropertiesOf.Clear();
            base.Delete();
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelClass);
        }

        /// <inheritdoc/>
        public bool Equals(PersonnelClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope;
        }

        /// <inheritdoc/>
        public static bool operator ==(PersonnelClass? left, PersonnelClass? right)
        {
            return EqualityComparer<PersonnelClass?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PersonnelClass? left, PersonnelClass? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode());
        }

        /// <inheritdoc/>
        public List<Guid> GetHaveChildClassDtIdList()
        {
            return this.IncludesPropertiesOf.Where(m => m.Target.IsDelete == false).Select(m => m.DtId).ToList();
        }

        /// <inheritdoc/>
        public void IncludesPropertiesOfAddTarget(Guid targetDtId)
        {
            this.IncludesPropertiesOf.Add(new PersonnelClassIncludesPropertiesOfRelationship(this.DtId, targetDtId));
        }

        /// <inheritdoc/>
        public void IncludesPropertiesOfRemoveTargets(IEnumerable<Guid> deleteDtIds)
        {
            this.IncludesPropertiesOf.RemoveAll(m => deleteDtIds.Contains(m.TargetId));
        }

        /// <inheritdoc/>
        public void IncludesPropertiesOfAddTarget(PersonnelClass target)
        {
            this.IncludesPropertiesOf.Add(new PersonnelClassIncludesPropertiesOfRelationship(this, target));
        }
    }
}