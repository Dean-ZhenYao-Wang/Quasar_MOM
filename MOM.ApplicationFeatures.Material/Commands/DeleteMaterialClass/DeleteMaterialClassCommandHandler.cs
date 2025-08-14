using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Material.Commands.DeleteMaterialClass
{
    public class DeleteMaterialClassCommandHandler(IMaterialClassRepository materialClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeleteMaterialClassCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteMaterialClassCommand request, CancellationToken cancellationToken)
        {
            await materialClassRepository.DeleteRangeAsync(request.DtIds);
            
            return BaseResult.Ok();
        }
    }
}
