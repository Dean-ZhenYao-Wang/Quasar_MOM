using MediatR;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.CodingRule.Commands.RegisterRule
{
    public class RegisterRuleCommand : MOM.Domain.CodingRule.CodingRule,IRequest<BaseResult>
    {
    }
}
