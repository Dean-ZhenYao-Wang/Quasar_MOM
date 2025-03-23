using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Personnel.Commands.AddPerson
{
    public class AddPersonCommandHandler(IPersonRepository personRepository, IUnitOfWork unitOfWork) : IRequestHandler<AddPersonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            await personRepository.AddAsync(request.ToPerson());
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
