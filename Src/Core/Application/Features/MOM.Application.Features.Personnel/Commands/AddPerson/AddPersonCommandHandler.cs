using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Infrastructure.Extensions;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.Features.Personnel.Commands.AddPerson
{
    public class AddPersonCommandHandler(IPersonRepository personRepository, IUnitOfWork unitOfWork, IMediator mediator) : IRequestHandler<AddPersonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            using var transaction = await unitOfWork.BeginTransactionAsync();
            try
            {
                Person addPerson = request.ToPerson();
                addPerson.Id =
                    string.IsNullOrWhiteSpace(request.Id)
                    ? await mediator.Send(new GenerateCodeCommand { RuleId = "UserId", ModelTypeName = "MOM.Domain.isa95.CommonObjectModels.Part2.Personnel.Person,MOM.Domain" })
                    : request.Id;
                addPerson.PassWord = "123456".Sha1Signature().Sha1Signature(addPerson.DtId.ToString());
                await personRepository.AddAsync(addPerson);
                await unitOfWork.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
            return BaseResult.Ok();
        }
    }
}