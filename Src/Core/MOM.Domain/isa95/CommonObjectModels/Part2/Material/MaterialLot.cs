namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialDefinition;
    using MOM.Domain.Common.Relationship.isa95.MaterialLot;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    public partial class MaterialLot : Resource, IEquatable<MaterialLot>
    {
        public MaterialLot()
        {
        }

        /// <summary>
        /// 由...组成
        /// </summary>
        /// <remarks>
        /// 表示一个父批次是由一个或多个子批次或其他物料批次构成的。
        /// <para>关系类型：组合（Composition），表示强生命周期依赖，父批次管理子批次的生命周期。</para>
        /// <para>场景：一个成品批次（Lot-A）是通过将原材料批次（Lot-B 和 Lot-C）混合或组装而成的。</para>
        /// <para>关系：Lot-A isAssembledFrom Lot-B, Lot-C</para>
        /// <para>这是构建批次级BOM（Bill of Materials） 和实现正向/逆向追溯的核心关系。</para>
        /// </remarks>
        [JsonIgnore]
        public virtual List<MaterialLotIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<MaterialLotIsAssembledFromRelationship>();

        /// <summary>
        /// 该物料批次所具有的具体属性值（如实际测量的密度、湿度、批次特有参数等）。
        /// </summary>
        /// <remarks>
        /// 关系类型：组合（Composition），属性值属于该批次的一部分。
        /// </remarks>
        public virtual MaterialLotProperty HasValuesOf { get; set; } = new MaterialLotProperty();
        /// <summary>
        /// 由...定义
        /// </summary>
        /// <remarks>
        /// 该物料批次所依据的物料定义（Material Definition），即该批次是哪个‘模板’的实例。
        /// <para>关系类型：关联（Association），表示此批次基于某个标准化的物料定义创建。</para>
        /// </remarks>
        public virtual List<MaterialLotDefinedByRelationship> DefinedBy { get; set; } = new List<MaterialLotDefinedByRelationship>();
        /// <summary>
        /// 由...子批次组成
        /// </summary>
        /// <remarks>
        /// 此物料批次由一个或多个物料子批次构成。
        /// <para>关系类型：聚合（Aggregation），表示弱关联，子批次可独立存在。</para>
        /// </remarks>
        [JsonIgnore]
        public virtual List<MaterialLotIsAssembledFromSublotRelationship> IsAssembledFromSublot { get; set; } = new List<MaterialLotIsAssembledFromSublotRelationship>();
        /// <summary>
        /// 描述
        /// </summary>
        /// <remarks>
        /// 关于该物料批次的补充信息，例如生产备注、特殊处理要求等。
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
        /// 适合存放地点
        /// </summary>
        /// <remarks>
        /// 可选关系，指向具体的存储位置对象（如库位、工位、设备等）。
        /// <para>用于增强位置追踪能力</para>
        /// </remarks>
        public Guid? StorageLocationRelDtId { get; set; }
        /// <summary>
        /// 适合存放地点
        /// </summary>
        /// <remarks>
        /// 可选关系，指向具体的存储位置对象（如库位、工位、设备等）。
        /// <para>用于增强位置追踪能力</para>
        /// </remarks>
        [ForeignKey(nameof(StorageLocationRelDtId))]
        [JsonIgnore]
        public virtual Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation StorageLocationRel { get; set; }
        /// <summary>
        /// 存储位置。
        /// </summary>
        /// <remarks>
        /// 标识该物料批次当前的存储位置。
        /// </remarks>
        public string? StorageLocation { get => StorageLocationRel?.HierarchyScopeRel.FullPath; }

        /// <summary>
        /// 存储位置类型；当指定了存储位置时，此字段为必填。
        /// </summary>
        /// <remarks>
        /// 说明 storageLocation 字段所指代的对象类型。
        /// </remarks>
        public MaterialLotStorageLocationType? StorageLocationType { get; set; }
        /// <summary>
        /// 装配类型
        /// </summary>
        /// <remarks>
        /// 定义该批次作为装配体时的类型。
        /// </remarks>
        public MaterialLotAssemblyType? AssemblyType { get; set; }
        /// <summary>
        /// 装配关系
        /// </summary>
        /// <remarks>
        /// 定义该装配关系的持久性。
        /// </remarks>
        public MaterialLotAssemblyRelationship? AssemblyRelationship { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        /// <remarks>
        /// 物料批次在制造过程中的状态，具体值由系统实现定义（如 'Active', 'Hold' 等）。
        /// </remarks>
        public string? Status { get; set; }
        /// <summary>
        /// 处置状态
        /// </summary>
        /// <remarks>
        /// 物料批次在计划与物流中的处理状态。
        /// </remarks>
        public MaterialLotDisposition? Disposition { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        /// <remarks>
        /// 该物料批次的数量（如 100.5 kg 或 500 件）。
        /// </remarks>
        public double? Quantity { get; set; }

        /// <summary>
        /// 数量单位
        /// </summary>
        /// <remarks>
        /// 与数量对应的计量单位（如 kg、pcs、m、L 等）。
        /// </remarks>
        public string? QuantityUnitOfMeasure { get; set; }
        public MaterialLot(string ID, string description, string status, double? quantity = null, string? quantityUnitOfMeasure = null, MaterialLotDisposition? disposition = null, 
            MaterialLotStorageLocationType? storageLocationType = null, MaterialLotAssemblyType? assemblyType = null, MaterialLotAssemblyRelationship? assemblyRelationship = null) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.Status = status;
            this.Quantity = quantity;
            this.QuantityUnitOfMeasure = quantityUnitOfMeasure;
            this.Disposition = disposition;
            this.AssemblyType = assemblyType;
            this.AssemblyRelationship = assemblyRelationship;
        }

        public void DefinedByAddTarget(MaterialDefinition target)
        {
            this.DefinedBy.Add(new MaterialLotDefinedByRelationship(this, target));
        }

        public void DefinedByAddTarget(Guid materialDefinitionDtId)
        {
            this.DefinedBy.Add(new MaterialLotDefinedByRelationship(this.DtId, materialDefinitionDtId));
        }

        public void IsAssembledFromSubLotAddTarget(MaterialSublot target)
        {
            this.IsAssembledFromSublot.Add(new MaterialLotIsAssembledFromSublotRelationship(this, target));
        }

        public void IsAssembledFromSubLotAddTarget(Guid targetDtId)
        {
            this.IsAssembledFromSublot.Add(new MaterialLotIsAssembledFromSublotRelationship(this.DtId, targetDtId));
        }
        /// <summary>
        /// 更新当前物料批次的组成
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
                this.IsAssembledFrom.Add(new MaterialLotIsAssembledFromRelationship(this.DtId, item));
            }
        }
        /// <summary>
        /// 更新当前物料批次的定义
        /// </summary>
        /// <param name="childClassDtId"></param>
        public async void UpdateDefinedBy(List<Guid> childClassDtId)
        {
            var haveDtIds = this.DefinedBy.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childClassDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childClassDtId);
            foreach (var item in deleteDtIds)
            {
                this.DefinedBy.RemoveAll(m => m.TargetId == item);
            }
            foreach (var item in notHaveDtIds)
            {
                this.DefinedBy.Add(new MaterialLotDefinedByRelationship(this.DtId, item));
            }
        }
        /// <summary>
        /// 更新当前物料批次的子批次
        /// </summary>
        /// <param name="childClassDtId"></param>
        public async void UpdateIsAssembledFromSublot(List<Guid> childClassDtId)
        {
            var haveDtIds = this.IsAssembledFromSublot.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childClassDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childClassDtId);
            foreach (var item in deleteDtIds)
            {
                this.IsAssembledFromSublot.RemoveAll(m => m.TargetId == item);
            }
            foreach (var item in notHaveDtIds)
            {
                this.IsAssembledFromSublot.Add(new MaterialLotIsAssembledFromSublotRelationship(this.DtId, item));
            }
        }
        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialLot);
        }

        public bool Equals(MaterialLot? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && StorageLocation == other.StorageLocation && StorageLocationType == other.StorageLocationType && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship && Status == other.Status && Disposition == other.Disposition && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(MaterialLot? left, MaterialLot? right)
        {
            return EqualityComparer<MaterialLot?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialLot? left, MaterialLot? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), StorageLocation?.GetHashCode(), StorageLocationType?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode(), Status?.GetHashCode(), Disposition?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}