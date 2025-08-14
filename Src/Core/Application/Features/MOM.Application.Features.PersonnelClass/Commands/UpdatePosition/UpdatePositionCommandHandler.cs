using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.UpdatePosition
{
    public class UpdatePositionCommandHandler(IPersonnelClassRepository personnelClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<UpdatePositionCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdatePositionCommand request, CancellationToken cancellationToken)
        {
            var position = await personnelClassRepository.GetByKeyAsync(request.DtId);
            if (position == null)
            {
                return BaseResult.Failure(new Error(ErrorCode.NotFound, "Position not found."));
            }
            position.Id = request.Id;
            position.Name = request.Name;
            position.Remark = request.Remark;
            // Update other properties as needed
            await personnelClassRepository.UpdateAsync(position);

            return BaseResult.Ok();
        }
    }
}