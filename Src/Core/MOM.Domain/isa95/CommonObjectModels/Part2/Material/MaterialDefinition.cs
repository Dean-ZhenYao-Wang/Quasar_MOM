namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialClass;
    using MOM.Domain.Common.Relationship.isa95.MaterialDefinition;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    public partial class MaterialDefinition : Resource, IEquatable<MaterialDefinition>
    {
        public MaterialDefinition()
        {
        }
        /// <summary>
        /// 由...组成
        /// </summary>
        /// <remarks>
        /// 此物料定义作为‘整体’，由其他物料定义作为‘组成部分’构成。例如：一个组件由多个子零件组成。
        /// <para>关系类型：组合（Composition），表示强生命周期依赖，父对象管理子对象的生命周期。</para>
        /// </remarks>
        [JsonIgnore]
        public virtual List<MaterialDefinitionIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<MaterialDefinitionIsAssembledFromRelationship>();

        /// <summary>
        /// 具有以下属性。
        /// </summary>
        /// <remarks>
        /// 该物料定义所拥有的具体物料属性（如颜色、密度、批次要求等）。
        /// </remarks>
        public virtual MaterialDefinitionProperty Property { get; set; } = new MaterialDefinitionProperty();

        /// <summary>
        /// 属于类别
        /// </summary>
        /// <remarks>
        /// 表示该物料定义是某个物料类别的成员。一个物料定义可属于零个或多个物料类别。
        /// <para>关系类型：关联（Association），表示松耦合关系，不共享生命周期。</para>
        /// </remarks>
        [JsonIgnore]
        public virtual List<MaterialDefinitionIsMemberOfClassRelationship> IsMemberOfClass { get; set; } = new List<MaterialDefinitionIsMemberOfClassRelationship>();
        /// <summary>
        /// 描述
        /// </summary>
        /// <remarks>
        /// 关于该物料定义的补充信息，例如用途说明、工艺要求、安全等级等。
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
        /// 定义该物料作为装配体时的类型，区分是物理连接还是逻辑组合。
        /// </remarks>
        public MaterialDefinitionAssemblyType? AssemblyType { get; set; }
        /// <summary>
        /// 装配关系
        /// </summary>
        /// <remarks>
        /// 定义该装配关系的性质，是永久性的还是临时性的。
        /// </remarks>
        public MaterialDefinitionAssemblyRelationship? AssemblyRelationship { get; set; }



        public MaterialDefinition(string ID, string description = "", MaterialDefinitionAssemblyType? assemblyType = null, MaterialDefinitionAssemblyRelationship? assemblyRelationship = null) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.AssemblyType = assemblyType;
            this.AssemblyRelationship = assemblyRelationship;
        }


        public override void Delete()
        {
            this.IsMemberOfClass.Clear();
            this.IsAssembledFrom.Clear();
            base.Delete();
        }

        public void Update(string iD, string description, MaterialDefinitionAssemblyType? assemblyType, MaterialDefinitionAssemblyRelationship? assemblyRelationship)
        {
            this.Id = Id;
            this.Description = description;
            this.AssemblyType = assemblyType;
            this.AssemblyRelationship = assemblyRelationship;
        }

        /// <summary>
        /// 更新当前物料定义的组成
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
                this.IsAssembledFrom.Add(new MaterialDefinitionIsAssembledFromRelationship(this.DtId, item));
            }
        }
        /// <summary>
        /// 更新当前物料定义的属于类别
        /// </summary>
        /// <param name="childClassDtId"></param>
        public async void UpdateIsMemberOfClass(List<Guid> childClassDtId)
        {
            var haveDtIds = this.IsMemberOfClass.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childClassDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childClassDtId);
            foreach (var item in deleteDtIds)
            {
                this.IsMemberOfClass.RemoveAll(m => m.TargetId == item);
            }
            foreach (var item in notHaveDtIds)
            {
                this.IsMemberOfClass.Add(new MaterialDefinitionIsMemberOfClassRelationship(this.DtId, item));
            }
        }
        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialDefinition);
        }

        public bool Equals(MaterialDefinition? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship;
        }

        public static bool operator ==(MaterialDefinition? left, MaterialDefinition? right)
        {
            return EqualityComparer<MaterialDefinition?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialDefinition? left, MaterialDefinition? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode());
        }
    }
}