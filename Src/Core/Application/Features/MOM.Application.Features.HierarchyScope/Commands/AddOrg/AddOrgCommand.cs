using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.HierarchyScope.Commands.AddOrg
{
    public class AddOrgCommand : AddOrgRequest, IRequest<BaseResult>
    {
    }
}
