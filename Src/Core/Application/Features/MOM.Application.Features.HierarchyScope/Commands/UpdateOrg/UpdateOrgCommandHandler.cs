using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateOrg
{
    public class UpdateOrgCommandHandler(IPersonnelClassRepository personnelClassRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateOrgCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateOrgCommand request, CancellationToken cancellationToken)
        {
            var Org = await personnelClassRepository.GetByIdAsync(request.DtId);

            if (Org is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }

            Org.Update(request.Id,request.ResponsibleDtId);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
