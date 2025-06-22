using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.CodingRule.Commands.RegisterRule
{
    public class RegisterRuleCommand : CodingRuleRequest, IRequest<BaseResult>
    {
        
    }
}
