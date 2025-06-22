using MediatR;

namespace MOM.Application.DTOs.CodingRule.Requests
{
    public class GenerateCodeCommand: IRequest<string>
    {
        /// <summary>
        /// 编码规则的唯一标识符
        /// 用于在CodingRuleManager中注册和检索规则
        /// 建议使用有意义的命名，如"PRODUCT_RULE"、"ORDER_RULE"等
        /// </summary>
        public string RuleId { get; set; }
        /// <summary>
        /// 目标EF Core模型类型
        /// 指定该编码规则适用于哪个实体模型
        /// 生成编码时会验证传入的模型对象是否匹配此类型
        /// </summary>
        public string? ModelTypeName { get; set; }
        /// <summary>
        /// 从数据库查询出来的当前对象实例，仅在后端生成编码时使用，给谁生成编码，这个实例就是谁
        /// </summary>
        public object? DbModel { get; set; }
    }
}
