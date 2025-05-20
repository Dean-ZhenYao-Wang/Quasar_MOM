using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.AddPsitoion
{
    public class AddPositionCommandHandler(IPersonnelClassRepository personnelClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<AddPositionCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddPositionCommand request, CancellationToken cancellationToken)
        {
            Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass addClass = request.ToPersonnelClass("职位");

            await personnelClassRepository.AddAsync(addClass);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}