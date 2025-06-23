using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateHierarchyScope
{
    public class UpdateHierarchyScopeCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateHierarchyScopeCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateHierarchyScopeCommand request, CancellationToken cancellationToken)
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

                await hierarchyScopeContainsRelationshipRepository.MoveNode(request.DtId, request.SourceDtId);
                await hierarchyScopeContainsRelationshipRepository.SaveChangesAsync();

                if (Org.SourceDtId != null)
                {
                    Org.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(Org.DtId);
                }

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