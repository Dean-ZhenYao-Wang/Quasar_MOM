using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateOrg
{
    public class UpdateOrgCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository,IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateOrgCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateOrgCommand request, CancellationToken cancellationToken)
        {
            var Org = await hierarchyScopeRepository.GetByIdAsync(request.DtId);

            if (Org is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }

            Org.Update(request.ToHierarchyScope());

            var oldSource = hierarchyScopeContainsRelationshipRepository
                .Where(m => m.TargetId.Equals(request.DtId))
                .FirstOrDefault();
            if(oldSource != null&&oldSource.SourceId!=request.SourceDtId)
            {
                oldSource.IsDelete = false;
            }
            else
            {
                if(request.SourceDtId != null)
                {
                    await hierarchyScopeContainsRelationshipRepository.AddAsync(new HierarchyScopeContainsRelationship(request.SourceDtId,request.DtId));
                }
            }



            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
