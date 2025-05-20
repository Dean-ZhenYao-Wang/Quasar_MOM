using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.UpdatePosition
{
    public class UpdatePositionCommandHandler(IPersonnelClassRepository personnelClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<UpdatePositionCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdatePositionCommand request, CancellationToken cancellationToken)
        {
            var position = await personnelClassRepository.GetByIdAsync(request.DtId);
            if (position == null)
            {
                return BaseResult.Failure(new Error(ErrorCode.NotFound, "Position not found."));
            }
            position.Id = request.Id;
            position.Remark = request.Remark;
            // Update other properties as needed
            personnelClassRepository.Update(position);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}