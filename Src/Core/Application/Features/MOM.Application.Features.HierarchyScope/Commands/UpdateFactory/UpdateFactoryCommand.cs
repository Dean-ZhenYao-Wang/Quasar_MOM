using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Features.HierarchyScope.Commands.UpdateEnterpriseOrDepartment;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateFactoryCommand : UpdateOrgRequest, IRequest<BaseResult>
    {
    }
}
