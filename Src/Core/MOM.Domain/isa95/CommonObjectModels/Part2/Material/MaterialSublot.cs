namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialSublot;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    public partial class MaterialSublot : Resource, IEquatable<MaterialSublot>
    {
        public MaterialSublot()
        {
        }

        /// <summary>
        /// 由...构成
        /// </summary>
        /// <remarks>
        /// 这个关系描述的是同一个物料批次内部的物理分割或聚合，即“这个子批次本身是由哪些更小的、可识别的部分组成的？”
        /// <para><term>语义：</term> “我由谁构成？” (这里的“我”是一个子批次)</para>
        /// <para><term>场景：</term> 一个物料批次（Lot-A）被生产出来后，被分装到了 5 个不同的桶里。这 5 个桶就是 5 个 MaterialSublot。</para>
        /// <list type="bullet">
        /// <item>现在，假设你想把其中 3 个桶的物料打包成一个发货单元。你可以创建一个新的 MaterialSublot (称为 Sublot-Shipment) 来代表这个发货单元。</item>
        /// <item>这个新的 Sublot-Shipment 并不是一个通过生产工序“组装”出来的新物料，而是物理上把3个已有的子批次“聚合”在一起。</item>
        /// <item>为了表示这种关系，你会说：Sublot-Shipment isMadeUpOf Sublot-1, Sublot-2, Sublot-3。</item>
        /// </list>
        /// <para><term>关键点：</term></para>
        /// <list type="bullet">
        /// <item>isMadeUpOf 不创造新物料，它只是对现有物料的物理分组。</item>
        /// <item>它发生在同一个 MaterialLot 内部，是对物料物理形态或管理方式的重新组织。</item>
        /// <item>它更侧重于库存管理、物流和包装层面。</item>
        /// </list>
        /// </remarks>
        [JsonIgnore]
        public virtual List<MaterialSublotIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<MaterialSublotIsMadeUpOfRelationship>();

        /// <summary>
        /// 具有以下属性值
        /// </summary>
        /// <remarks>
        /// 该物料子批次所拥有的具体属性值（如实际测量的密度、湿度、批次特有参数等）。
        /// <para>关系类型：组合（Composition），属性值属于该子批次的一部分。</para>
        /// </remarks>
        public virtual MaterialLotProperty Property { get; set; } = new MaterialLotProperty();

        /// <summary>
        /// 由...组装而成；此关系用于构建子批次层级结构或装配路径
        /// </summary>
        /// <remarks>
        /// 描述一个子批次是基于另一个子批次“构造”或“派生”出来的。这可以理解为一种更精细的组装或转换。
        /// <para>关系类型：组合（Composition），表示强生命周期依赖，父对象管理子对象的生命周期。</para>
        /// <para>场景：一个子批次（Sublot-1）经过一道工序后，变成了一个新的子批次（Sublot-2），后者是前者的直接产物。</para>
        /// <para>关系：Sublot-2 isAssembledFrom Sublot-1</para>
        /// <para>它强调的是生产流程上的前后关系。</para>
        /// </remarks>
        [JsonIgnore]
        public virtual List<MaterialSublotIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<MaterialSublotIsAssembledFromRelationship>();

        /// <summary>
        /// 组成当前子批次的批次
        /// </summary>
        /// <remarks>
        /// 我（这个物料子批次）是从哪个物料批次（Material Lot）来的？核心作用是建立子批次与父批次之间的归属关系。
        /// </remarks>
        [JsonIgnore]
        public virtual List<MaterialSublotIsAssembledFromLotRelationship> IsAssembledFromLot { get; set; } = new List<MaterialSublotIsAssembledFromLotRelationship>();
        /// <summary>
        /// 描述
        /// </summary>
        /// <remarks>
        /// 关于该物料子批次的补充信息，例如特殊处理要求、包装方式等。
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

        public MaterialSublot(string ID, string description, double quantity, string quantityUnitOfMeasure) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.Quantity = quantity;
            this.QuantityUnitOfMeasure = quantityUnitOfMeasure;
        }

        public void IsAssembledFromLotAddTarget(MaterialLot target)
        {
            this.IsAssembledFromLot.Add(new MaterialSublotIsAssembledFromLotRelationship(this, target));
        }

        public void IsAssembledFromLotAddTarget(Guid materialLotDtId)
        {
            this.IsAssembledFromLot.Add(new MaterialSublotIsAssembledFromLotRelationship(this.DtId, materialLotDtId));
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSublot);
        }

        public bool Equals(MaterialSublot? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && StorageLocation == other.StorageLocation && StorageLocationType == other.StorageLocationType && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship && Status == other.Status && Disposition == other.Disposition && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(MaterialSublot? left, MaterialSublot? right)
        {
            return EqualityComparer<MaterialSublot?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSublot? left, MaterialSublot? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), StorageLocation?.GetHashCode(), StorageLocationType?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode(), Status?.GetHashCode(), Disposition?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}