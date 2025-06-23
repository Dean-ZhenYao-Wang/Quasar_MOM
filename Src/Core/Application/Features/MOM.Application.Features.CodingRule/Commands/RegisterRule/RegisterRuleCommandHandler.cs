using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.CodingRule.Commands.RegisterRule
{
    public class RegisterRuleCommandHandler(ICodingRuleRepository codingRuleRepository, IUnitOfWork unitOfWork) : IRequestHandler<RegisterRuleCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(RegisterRuleCommand request, CancellationToken cancellationToken)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (string.IsNullOrEmpty(request.Id)) throw new ArgumentException("规则ID不能为空");

            var existing = await codingRuleRepository.GetRuleAsync(request.Id);

            if (existing != null)
            {
                codingRuleRepository.Delete(existing);
            }

            await codingRuleRepository.AddAsync(request.ToCodingRule());

            await codingRuleRepository.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}