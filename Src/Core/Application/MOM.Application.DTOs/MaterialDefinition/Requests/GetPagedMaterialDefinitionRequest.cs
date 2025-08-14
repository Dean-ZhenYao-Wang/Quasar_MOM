using MOM.Application.Wrappers;
using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.MaterialDefinition;

namespace MOM.Application.DTOs.MaterialDefinition.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPagedMaterialDefinitionRequest : PaginationRequestParameter
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
        public Guid? HierarchyScopeRelDtId { get; set; }// <summary>
        /// 由...组成
        /// </summary>
        /// <remarks>
        /// 此物料定义作为‘整体’，由其他物料定义作为‘组成部分’构成。例如：一个组件由多个子零件组成。
        /// <para>关系类型：组合（Composition），表示强生命周期依赖，父对象管理子对象的生命周期。</para>
        /// </remarks>
        public Guid? IsAssembledFrom_TargetDtId { get; set; }
        /// <summary>
        /// 属于类别
        /// </summary>
        /// <remarks>
        /// 表示该物料定义是某个物料类别的成员。一个物料定义可属于零个或多个物料类别。
        /// <para>关系类型：关联（Association），表示松耦合关系，不共享生命周期。</para>
        /// </remarks>
        public Guid? IsMemberOfClass_TargetDtId { get; set; }
}
}