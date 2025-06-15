using MediatR;
using MOM.Application.Features.CodingRule.Commands.RegisterRule;

namespace MOM.Application.Features.CodingRule.Commands.GenerateCode
{
    public class GenerateCodeCommand: IRequest<string>
    {
        /// <summary>
        /// 编码规则ID
        /// </summary>
        public string RuleId { get; set; }
        /// <summary>
        /// EF Core模型实例，可以为null（当规则不依赖模型属性时）
        /// </summary>
        public object Model { get; set; }
    }
}
