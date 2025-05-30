﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.DeleteOrg
{
    public class DeleteOrgCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<DeleteOrgCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteOrgCommand command, CancellationToken cancellationToken)
        {
            using var transaction = await unitOfWork.BeginTransactionAsync();
            try
            {
                await hierarchyScopeRepository.DeleteAsync(command.DtIds);


                await hierarchyScopeContainsRelationshipRepository.DeletePath(command.DtIds);


                await unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                await unitOfWork.RollbackAsync();
                throw new ApplicationException(ex.Message, ex.InnerException);
            }

            return BaseResult.Ok();
        }
    }
}