using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.DeletePerson
{
    public class DeletePersonCommand : IRequest<BaseResult>
    {
        public Guid[] DtIds { get; set; }
    }
}
