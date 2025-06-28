using MOM.Application.Wrappers;
using MOM.Domain.Common.EnumType;

namespace MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPagedEquipmentRequest : PaginationRequestParameter
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 设备层级
        /// </summary>
        /// <remarks>
        /// 基于角色的设备层级中的级别标识
        /// </remarks>
        public EquipmentEquipmentLevel? EquipmentLevel { get; set; }
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
        /// 所属设备类
        /// </summary>
        public Guid? DefinedByDtId { get; set; }
        /// <summary>
        /// 设备状态
        /// </summary>
        public EquipmentStatusType? Status { get; set; }
    }
}