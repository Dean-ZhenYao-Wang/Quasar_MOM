using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.CodingRule.Commands.RegisterRule
{
    public class RegisterRuleCommand : CodingRuleRequest, IRequest<BaseResult>
    {
    }
}