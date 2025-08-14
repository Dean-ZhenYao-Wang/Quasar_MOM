using MediatR;
using MOM.Application.DTOs.MaterialClass.Requests;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Material.Commands.AddMaterialClass
{
    public class AddMaterialClassCommannd : AddMaterialClassRequest, IRequest<BaseResult>
    {
    }
}
