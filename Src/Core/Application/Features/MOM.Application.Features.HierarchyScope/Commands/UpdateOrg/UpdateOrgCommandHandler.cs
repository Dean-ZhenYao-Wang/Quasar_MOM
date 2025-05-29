using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateOrg
{
    public class UpdateOrgCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateOrgCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateOrgCommand request, CancellationToken cancellationToken)
        {
            using var tran = await unitOfWork.BeginTransactionAsync();
            try
            {

                var Org = await hierarchyScopeRepository.GetByIdAsync(request.DtId);

                if (Org is null)
                {
                    return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
                }

                Org.Update(request.ToHierarchyScope());
                if (request.SourceDtId == null)
                    Org.FullPath = Org.Name;

                //await hierarchyScopeContainsRelationshipRepository.MoveNodeAsync(request.DtId, request.SourceDtId);

                await unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await unitOfWork.RollbackAsync();
                throw;
            }
            return BaseResult.Ok();
        }
    }
}