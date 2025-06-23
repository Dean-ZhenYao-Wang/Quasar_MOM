namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.EquipmentClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 设备类别
    /// </summary>
    /// <remarks>
    /// <para>表示具有相似特性的设备分组，用于特定目的（如制造运营定义、调度、能力和性能），应表示为设备类别。</para>
    /// <para>任何设备可能是零个或多个设备类别的成员。</para>
    /// <para>设备类别可定义为零个或多个设备类别的特化。</para>
    /// <para>设备类别可由零个或多个设备类别组成</para>
    /// </remarks>
    public partial class EquipmentClass : ResourceClass, IEquatable<EquipmentClass>
    {
        private EquipmentClass() { }
        /// <summary>
        /// 当前分类包含的子分类。<br/>
        /// 父子关系（主要类别，如生产类、一起类、辅助类、工具类、运输类、管理类等）<br/>
        /// 设备->主要设备->甲类设备<br/>
        /// 设备->主要设备->乙类设备<br/>
        /// 设备->产线->罐装产线
        /// </summary>
        /// <remarks>
        /// 包含...的属性
        /// <para>此设备类别包含目标设备类别的属性</para>
        /// </remarks>
        [JsonIgnore]
        public virtual List<EquipmentClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<EquipmentClassIncludesPropertiesOfRelationship>();

        /// <summary>
        /// 这个父设备类是子设备类的整体。<br/>
        /// 组成关系（具体的设备类别，如反应器、压缩机、CNC、叉车、行车等）<br/>
        /// 罐装产线->A类设备<br/>
        /// 罐装产线->B类设备<br/>
        /// A类设备与B类设备共同组成罐装产线
        /// </summary>
        /// <remarks>
        /// 由...组成
        /// <para>此父设备类别作为整体，由子设备类别作为组成部分</para>
        /// </remarks>
        [JsonIgnore]
        public virtual List<EquipmentClassIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentClassIsMadeUpOfRelationship>();

        /// <summary>
        /// 具有的属性
        /// </summary>
        public virtual EquipmentClassProperty Property { get; set; } = new EquipmentClassProperty();

        /// <summary>
        /// 描述
        /// </summary>
        /// <remarks>
        /// 设备类别的补充信息
        /// </remarks>
        public string? Description { get; set; }

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
        public virtual HierarchyScope? HierarchyScopeRel { get; set; }

        /// <summary>
        /// 设备层级
        /// </summary>
        public EquipmentClassEquipmentLevel? EquipmentLevel { get; set; }

        /// <summary>
        /// 更新子分类
        /// </summary>
        /// <param name="childClassDtId"></param>
        public void UpdateIncludesPropertiesOf(List<Guid> childClassDtId)
        {
            var haveDtIds = this.IncludesPropertiesOf.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childClassDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childClassDtId);
            foreach (var item in deleteDtIds)
            {
                this.IncludesPropertiesOf.RemoveAll(m => m.TargetId == item);
            }
            foreach (var item in notHaveDtIds)
            {
                this.IncludesPropertiesOf.Add(new Common.Relationship.isa95.EquipmentClass.EquipmentClassIncludesPropertiesOfRelationship(this.DtId, item));
            }
        }

        /// <summary>
        /// 更新当前设备类的组成部分
        /// </summary>
        /// <param name="childClassDtId"></param>
        public async void UpdateIsMadeUpOf(List<Guid> childClassDtId)
        {
            var haveDtIds = this.IsMadeUpOf.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childClassDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childClassDtId);
            foreach (var item in deleteDtIds)
            {
                this.IsMadeUpOf.RemoveAll(m => m.TargetId == item);
            }
            foreach (var item in notHaveDtIds)
            {
                this.IsMadeUpOf.Add(new Common.Relationship.isa95.EquipmentClass.EquipmentClassIsMadeUpOfRelationship(this.DtId, item));
            }
        }

        /// <summary>
        /// 更新当前设备类
        /// </summary>
        /// <param name="iD"></param>
        /// <param name="description"></param>
        /// <param name="equipmentLevel"></param>
        public void Update(string iD, string? description, EquipmentClassEquipmentLevel? equipmentLevel)
        {
            this.Id = Id;
            this.Description = description;
            this.EquipmentLevel = equipmentLevel;
        }

        /// <summary>
        /// 软删除当前设备类
        /// </summary>
        public override void Delete()
        {
            this.IncludesPropertiesOf.Clear();
            base.Delete();
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClass);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && EquipmentLevel == other.EquipmentLevel;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentClass? left, EquipmentClass? right)
        {
            return EqualityComparer<EquipmentClass?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentClass? left, EquipmentClass? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), EquipmentLevel?.GetHashCode());
        }
    }
}