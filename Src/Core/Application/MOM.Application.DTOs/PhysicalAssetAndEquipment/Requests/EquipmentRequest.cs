using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.Equipment;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;
using System.ComponentModel.DataAnnotations;

namespace MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class EquipmentRequest
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// 设备的补充信息
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// 设备层级
        /// </summary>
        /// <remarks>
        /// 基于角色的设备层级中的级别标识
        /// </remarks>
        public required EquipmentEquipmentLevel EquipmentLevel { get; set; }
        /// <summary>
        /// 所属设备类清单
        /// <para>此设备支持的设备类别</para>
        /// </summary>
        /// <remarks>
        /// 关系类型：关联
        /// </remarks>
        public required List<Guid> DefinedBy { get; set; } = new List<Guid>();
        /// <summary>
        /// 此设备的属性值
        /// </summary>
        public EquipmentProperty Property { get; set; } = new EquipmentProperty();

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
        /// 责任人DtId
        /// </summary>
        public Guid? ResponsibleDtId { get; set; }
        /// <summary>
        /// 设备状态
        /// </summary>
        public required EquipmentStatusType Status { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        public required string Supplier { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public required string Specification { get; set; }
        /// <summary>
        /// 出厂编号
        /// </summary>
        public required string FactoryNumber { get; set; }
    }
}