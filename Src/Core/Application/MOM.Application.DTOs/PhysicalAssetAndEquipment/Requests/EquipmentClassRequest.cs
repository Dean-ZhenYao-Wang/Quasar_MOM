using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests
{
    /// <summary>
    ///
    /// </summary>
    public class EquipmentClassRequest
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 具有的属性
        /// </summary>
        public EquipmentClassProperty Property { get; set; } = new EquipmentClassProperty();

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
        /// 设备层级
        /// </summary>
        public EquipmentClassEquipmentLevel? EquipmentLevel { get; set; }
    }
}