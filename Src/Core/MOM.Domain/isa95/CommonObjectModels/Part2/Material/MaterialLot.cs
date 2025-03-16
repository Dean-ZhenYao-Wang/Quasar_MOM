namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialLot;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialLot : Resource, IEquatable<MaterialLot>
    {
        public MaterialLot()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialLot;1";

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
        public MaterialLotStorageLocationType? StorageLocationType { get; set; }

        /// <summary>
        /// 定义组装类型
        /// </summary>
        [JsonPropertyName("assemblyType")]
        public MaterialLotAssemblyType? AssemblyType { get; set; }

        /// <summary>
        /// 定义组装关系的类型
        /// </summary>
        [JsonPropertyName("assemblyRelationship")]
        public MaterialLotAssemblyRelationship? AssemblyRelationship { get; set; }

        /// <summary>
        /// 物料在生产作业中的状态。实现定义的值
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 一个物料批次或物料批次组装的计划和物流处置。
        /// </summary>
        [JsonPropertyName("disposition")]
        public MaterialLotDisposition? Disposition { get; set; }

        /// <summary>
        /// 物料批次的数量。
        /// </summary>
        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// 相关量的度量单位
        /// </summary>
        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        /// <summary>
        /// 组成当前批次的批次
        /// </summary>
        /// <remarks>组合关系<br></br>This material lot is part of the related object as the whole<br></br>这批材料作为整体是相关对象的一部分</remarks>
        [JsonIgnore]
        public virtual MaterialLotIsAssembledFromRelationshipCollection IsAssembledFrom { get; set; } = new MaterialLotIsAssembledFromRelationshipCollection();

        /// <summary>
        /// 该物料批次的物料批次属性
        /// </summary>
        [JsonIgnore]
        public virtual MaterialLotHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new MaterialLotHasValuesOfRelationshipCollection();

        /// <summary>
        /// 定义这批材料的材料定义
        /// </summary>
        [JsonIgnore]
        public virtual MaterialLotDefinedByRelationshipCollection DefinedBy { get; set; } = new MaterialLotDefinedByRelationshipCollection();

        /// <summary>
        /// 组成当前批次的子批次
        /// </summary>
        /// <remarks>组合关系<br></br>This material lot is part of the related object as the whole<br></br>这批材料作为整体是相关对象的一部分</remarks>
        [JsonIgnore]
        public virtual MaterialLotIsAssembledFromSublotRelationshipCollection IsAssembledFromSublot { get; set; } = new MaterialLotIsAssembledFromSublotRelationshipCollection();

        /// <summary>
        /// 适合层次结构范围
        /// </summary>
        /// <remarks>可选的层次关系。不是标准规格的一部分。</remarks>
        [JsonIgnore]
        public virtual MaterialLotHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new MaterialLotHierarchyScopeRelRelationshipCollection();

        /// <summary>
        /// 适合存放地点
        /// </summary>
        /// <remarks>与存储位置的可选关系。不是标准规格的一部分。</remarks>
        [JsonIgnore]
        public virtual MaterialLotStorageLocationRelRelationshipCollection StorageLocationRel { get; set; } = new MaterialLotStorageLocationRelRelationshipCollection();

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