using MediatR;
using MOM.Application.Wrappers;
using static System.Net.WebRequestMethods;

namespace MOM.Application.Features.HierarchyScope.Commands.DeleteOrg
{
    public class DeleteOrgCommand : IRequest<BaseResult>
    {
        public Guid[] DtIds { get; set; }
    }
}
