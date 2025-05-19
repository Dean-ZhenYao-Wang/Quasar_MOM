using MediatR;
using MOM.Application.Infrastructure.Extensions;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Commands.AddPsitoion
{
    public class AddPositionCommandHandler(IPersonnelClassRepository personnelClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<AddPositionCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddPositionCommand request, CancellationToken cancellationToken)
        {
            Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass addPerson = request.ToPersonnelClass("职位");

            await personnelClassRepository.AddAsync(addPerson);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
