using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Material.Commands.DeleteMaterialDefinition
{
    public class DeleteMaterialDefinitionCommandHandler(IMaterialDefinitionRepository materialDefinitionRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeleteMaterialDefinitionCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteMaterialDefinitionCommand request, CancellationToken cancellationToken)
        {
            await materialDefinitionRepository.DeleteRangeAsync(request.DtIds);
            
            return BaseResult.Ok();
        }
    }
}
