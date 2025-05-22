using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.UpdatePerson
{
    public class UpdatePersonCommandHandler(IPersonRepository personRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdatePersonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            //var person = await personRepository.GetByIdAsync(request.DtId);

            //if (person is null)
            //{
            //    return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            //}

            //person.Update(request.Id, request.Name, request.WorkStatus, request.Email, request.PhoneNumber, request.TeamDtId, request.OrgDtId, request.PositionDtId_List, request.Description);
            //await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}