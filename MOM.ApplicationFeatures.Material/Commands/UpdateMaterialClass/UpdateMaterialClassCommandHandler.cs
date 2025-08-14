using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Material.Commands.UpdateMaterialClass
{
    public class UpdateMaterialClassCommandHandler(IMaterialClassRepository materialClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<UpdateMaterialClassCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateMaterialClassCommand request, CancellationToken cancellationToken)
        {
            var old = materialClassRepository.Where(x => x.DtId == request.DtId)
                .Include(m => m.IncludesPropertiesOf)
                .FirstOrDefault();
            if (old == null)
                throw new KeyNotFoundException("物料类不存在");
            if (!string.IsNullOrEmpty(request.Id))
                old.Id = request.Id;
            old.Name = request.Name;
            old.Property = request.Property;
            old.Description = request.Description;
            if (request.IncludesPropertiesOf_SourceDtId != null)
                old.UpdateIncludesPropertiesOf(new List<Guid> { request.IncludesPropertiesOf_SourceDtId.Value });
            if (request.IsAssembledFrom_SourceDtId.Count > 0)
                old.UpdateIsAssembledFrom(request.IsAssembledFrom_SourceDtId);

            return BaseResult.Ok();
        }
    }
}
