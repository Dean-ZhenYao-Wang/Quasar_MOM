namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    public partial class MaterialClass : ResourceClass, IEquatable<MaterialClass>
    {
        public MaterialClass()
        {
        }

        /// <summary>
        /// 线性分类 在物料主数据建设工程，往往分类采用线分类   https://zhuanlan.zhihu.com/p/496464306
        /// 当前分类包含的子分类
        /// </summary>
        /// <remarks>
        /// 父子关系
        /// <para>此物料类别包含其他物料类别的属性（即继承或复用其特性）。用于表达物料类之间的属性聚合或复用关系。</para>
        /// </remarks>
        public virtual List<MaterialClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<MaterialClassIncludesPropertiesOfRelationship>();
        /// <summary>
        /// 面分类 又称平行分类 物料模板采用面分类 https://zhuanlan.zhihu.com/p/496464306
        /// 组成当前分类的类型
        /// </summary>
        /// <remarks>
        /// 表示父级物料类别由一个或多个子级物料类别作为组成部分构成。
        /// <para>例如：成品由半成品或原材料组装而成。</para>
        /// </remarks>
        public virtual List<MaterialClassIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<MaterialClassIsAssembledFromRelationship>();
        /// <summary>
        /// 该物料类的物料类属性。
        /// </summary>
        public virtual MaterialClassProperty Property { get; set; } = new MaterialClassProperty();
        /// <summary>
        /// 描述
        /// </summary>
        /// <remarks>
        /// 关于该物料类别的补充说明信息，例如用途、工艺要求等。
        /// </remarks>
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
        public virtual HierarchyScope? HierarchyScopeRel { get; set; }


        /// <summary>
        /// 装配类型
        /// </summary>
        /// <remarks>
        /// 定义该物料类作为装配体时的类型，区分是物理连接还是逻辑组合。
        /// </remarks>
        public MaterialClassAssemblyType? AssemblyType { get; set; }

        /// <summary>
        /// 装配关系
        /// </summary>
        /// <remarks>
        /// 定义组件之间的装配关系性质，是永久性还是临时性的。
        /// </remarks>
        public MaterialClassAssemblyRelationship? AssemblyRelationship { get; set; }



        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialClass);
        }

        public bool Equals(MaterialClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship;
        }

        public static bool operator ==(MaterialClass? left, MaterialClass? right)
        {
            return EqualityComparer<MaterialClass?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialClass? left, MaterialClass? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode());
        }


        public MaterialClass(string ID, string name,string description = "", MaterialClassAssemblyType? assemblyType = null, MaterialClassAssemblyRelationship? assemblyRelationship = null) : this()
        {
            this.Id = Id;
            this.Name = name;
            this.Description = description;
            if (assemblyType != null)
                this.AssemblyType = assemblyType;
            if (assemblyRelationship != null)
                this.AssemblyRelationship = assemblyRelationship;
        }


        public override void Delete()
        {
            this.IncludesPropertiesOf.Clear();
            this.IsAssembledFrom.Clear();
            base.Delete();
        }

        public void Update(string iD, string description, MaterialClassAssemblyType? assemblyType, MaterialClassAssemblyRelationship? assemblyRelationship)
        {
            this.Id = Id;
            this.Description = description;
            this.AssemblyType = assemblyType;
            this.AssemblyRelationship = assemblyRelationship;
        }


        /// <summary>
        /// 更新当前物料类的线性分类
        /// </summary>
        /// <param name="childClassDtId"></param>
        public async void UpdateIncludesPropertiesOf(List<Guid> childClassDtId)
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
                this.IncludesPropertiesOf.Add(new MaterialClassIncludesPropertiesOfRelationship(this.DtId, item));
            }
        }

        /// <summary>
        /// 更新当前物料类的面分类
        /// </summary>
        /// <param name="childClassDtId"></param>
        public async void UpdateIsAssembledFrom(List<Guid> childClassDtId)
        {
            var haveDtIds = this.IsAssembledFrom.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childClassDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childClassDtId);
            foreach (var item in deleteDtIds)
            {
                this.IsAssembledFrom.RemoveAll(m => m.TargetId == item);
            }
            foreach (var item in notHaveDtIds)
            {
                this.IsAssembledFrom.Add(new MaterialClassIsAssembledFromRelationship(this.DtId, item));
            }
        }
    }
}