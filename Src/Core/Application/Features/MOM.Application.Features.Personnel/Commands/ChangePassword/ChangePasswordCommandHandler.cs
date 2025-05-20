using MediatR;
using MOM.Application.Infrastructure.Extensions;
using MOM.Application.Infrastructure.Services;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.ChangePassword
{
    public class ChangePasswordCommandHandler(ITranslator translator, IPersonRepository personRepository, IAuthenticatedUserService authenticated, IUnitOfWork unitOfWork) : IRequestHandler<ChangePasswordCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            Guid dtId = Guid.Parse(authenticated.DtId);
            var user = await personRepository.GetByIdAsync(dtId);
            string newPassWord = request.Password.Sha1Signature(authenticated.DtId);
            if (user.PassWord.Equals(newPassWord))
            {
                user.PassWord = newPassWord;
                user.SecurityStamp = Guid.NewGuid().ToString();
            }
            else
            {
                return BaseResult.Failure(new Error(ErrorCode.FieldDataInvalid, "密码错误"));
            }
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}