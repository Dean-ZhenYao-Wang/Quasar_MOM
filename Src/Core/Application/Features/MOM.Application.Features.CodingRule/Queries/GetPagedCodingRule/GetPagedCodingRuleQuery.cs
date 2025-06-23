using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.CodingRule.Queries.GetPagedCodingRule
{
    public class GetPagedCodingRuleQuery : PaginationRequestParameter, IRequest<PagedResponse<MOM.Domain.CodingRule.CodingRule>>
    {
        /// <summary>
        /// 编码规则的唯一标识符
        /// 用于在CodingRuleManager中注册和检索规则
        /// 建议使用有意义的命名，如"PRODUCT_RULE"、"ORDER_RULE"等
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// 编码规则的显示名称
        /// 用于用户界面显示和日志记录
        /// 例如："产品编码规则"、"订单编码规则"等
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 目标EF Core模型类型
        /// 指定该编码规则适用于哪个实体模型
        /// 生成编码时会验证传入的模型对象是否匹配此类型
        /// </summary>
        public string? ModelTypeName { get; set; }

        /// <summary>
        /// 规则是否激活
        /// true: 规则可用，可以被用于生成编码
        /// false: 规则被禁用，GetRulesByModelType等方法会过滤掉此规则
        /// </summary>
        public bool? IsActive { get; set; }
    }
}