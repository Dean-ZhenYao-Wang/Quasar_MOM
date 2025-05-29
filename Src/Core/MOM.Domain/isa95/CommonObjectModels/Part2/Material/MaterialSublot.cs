namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialSublot;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialSublot : Resource, IEquatable<MaterialSublot>
    {
        public MaterialSublot()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialSublot;1";

        /// <summary>
        /// 标识交换的信息在基于角色的设备层次结构中的位置。
        /// </summary>
        /// <remarks>可选地，层次作用域定义设备类的作用域，例如定义设备类的站点或区域。</remarks>
        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        /// <summary>
        /// 标识物料批次的存放位置。
        /// </summary>
        [JsonPropertyName("storageLocation")]
        public string? StorageLocation { get; set; }

        /// <summary>
        /// 指示存储位置属性是指操作位置、设备或物理资产对象，还是包含存储位置的描述。
        /// </summary>
        /// <remarks>指定存储位置时必选</remarks>
        [JsonPropertyName("storageLocationType")]
        public MaterialSublotStorageLocationType? StorageLocationType { get; set; }

        /// <summary>
        /// 定义组装类型
        /// </summary>
        [JsonPropertyName("assemblyType")]
        public MaterialSublotAssemblyType? AssemblyType { get; set; }

        /// <summary>
        /// 定义组装关系的类型
        /// </summary>
        [JsonPropertyName("assemblyRelationship")]
        public MaterialSublotAssemblyRelationship? AssemblyRelationship { get; set; }

        /// <summary>
        /// 物料在生产作业中的状态。实现定义的值
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 一个物料子批次或物料子批次组装的计划和物流处置。
        /// </summary>
        [JsonPropertyName("disposition")]
        public MaterialSublotDisposition? Disposition { get; set; }

        /// <summary>
        /// 物料子批次的数量。
        /// </summary>
        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// 相关量的度量单位
        /// </summary>
        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        /// <summary>
        /// 子批次的子批次，非组成关系，而是分解关系，当前子批次被分解成当前属性所指向的子批次清单
        /// IsMadeUpOf 与 IsAssembledFrom的定义还存疑，目前还不确定到底应该是什么定义
        /// </summary>
        /// <remarks>This material sublot is part of the related object as the whole<br></br>这个材料子批次是相关对象作为整体的一部分</remarks>
        [JsonIgnore]
public virtual List<MaterialSublotIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<MaterialSublotIsMadeUpOfRelationship>();

        /// <summary>
        /// 该物料子批次的物料子批次属性
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialSublotHasValuesOfRelationship> HasValuesOf { get; set; } = new List<MaterialSublotHasValuesOfRelationship>();

        /// <summary>
        /// 组成当前子批次的子批次
        /// IsMadeUpOf 与 IsAssembledFrom的定义还存疑，目前还不确定到底应该是什么定义
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialSublotIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<MaterialSublotIsAssembledFromRelationship>();

        /// <summary>
        /// 组成当前子批次的批次
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialSublotIsAssembledFromLotRelationship> IsAssembledFromLot { get; set; } = new List<MaterialSublotIsAssembledFromLotRelationship>();

        /// <summary>
        /// 适合层次结构范围
        /// </summary>
        /// <remarks>可选的层次关系。不是标准规格的一部分。</remarks>
        [JsonIgnore]
public virtual List<MaterialSublotHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<MaterialSublotHierarchyScopeRelRelationship>();

        /// <summary>
        /// 适合存放地点
        /// </summary>
        /// <remarks>与存储位置的可选关系。不是标准规格的一部分。</remarks>
        [JsonIgnore]
public virtual List<MaterialSublotStorageLocationRelRelationship> StorageLocationRel { get; set; } = new List<MaterialSublotStorageLocationRelRelationship>();

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