using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Material.Commands.UpdateMaterialDefinition
{
    public class UpdateMaterialDefinitionCommandHandler(IMaterialDefinitionRepository materialDefinitionRepository, IUnitOfWork unitOfWork) : IRequestHandler<UpdateMaterialDefinitionCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateMaterialDefinitionCommand request, CancellationToken cancellationToken)
        {
            var old = materialDefinitionRepository.Where(x => x.DtId == request.DtId).FirstOrDefault();
            if(!string.IsNullOrEmpty(request.Id))
                old.Id = request.Id;
            old.Name = request.Name;
            old.Property = request.Property;
            old.Description = request.Description;
            if (request.IsMemberOfClass_TargetDtId.Count > 0)
                old.UpdateIsMemberOfClass(request.IsMemberOfClass_TargetDtId);
            if (request.IsAssembledFrom_TargetDtId.Count > 0)
                old.UpdateIsAssembledFrom(request.IsAssembledFrom_TargetDtId);
            return BaseResult.Ok();
        }
    }
}
