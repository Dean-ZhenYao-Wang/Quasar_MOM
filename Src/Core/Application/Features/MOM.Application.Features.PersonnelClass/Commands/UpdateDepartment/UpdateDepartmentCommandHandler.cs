using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.UpdateDepartment
{
    public class UpdateDepartmentCommandHandler(IPersonnelClassRepository personnelClassRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateDepartmentCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await personnelClassRepository.GetByIdAsync(request.DtId);

            if (department is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }

            department.Update(request.Id,request.ResponsibleDtId);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
