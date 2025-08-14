using MOM.Application.Wrappers;
using MOM.Domain.Common.EnumType;

namespace MOM.Application.DTOs.MaterialClass.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPagedMaterialClasssRequest : PaginationRequestParameter
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
        public Guid? HierarchyScopeRelDtId { get; set; }
        /// <summary>
        /// 面分类 又称平行分类 物料模板采用面分类 https://zhuanlan.zhihu.com/p/496464306
        /// 组成当前分类的类型
        /// </summary>
        /// <remarks>
        /// 表示父级物料类别由一个或多个子级物料类别作为组成部分构成。
        /// <para>例如：成品由半成品或原材料组装而成。</para>
        /// </remarks>
        public Guid? IsAssembledFrom_SourceDtId { get; set; }

        /// <summary>
        /// 线性分类 在物料主数据建设工程，往往分类采用线分类   https://zhuanlan.zhihu.com/p/496464306
        /// 当前分类包含的子分类
        /// </summary>
        /// <remarks>
        /// 父子关系
        /// <para>此物料类别包含其他物料类别的属性（即继承或复用其特性）。用于表达物料类之间的属性聚合或复用关系。</para>
        /// </remarks>
        public Guid? IncludesPropertiesOf_SourceDtId { get; set; }
    }
}