using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
using MOM.Domain.isa95.EquipmentHierarchy;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Commands.AddDepartment
{
    public class AddDepartmentCommandHandler(IPersonnelClassRepository personnelClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<AddDepartmentCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddDepartmentCommand request, CancellationToken cancellationToken)
        {
            var model = request.ToPersonnelClass();
            await personnelClassRepository.AddAsync(model,request.SourceDtId);           
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
