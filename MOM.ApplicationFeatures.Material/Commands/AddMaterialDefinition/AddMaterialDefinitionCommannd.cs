using MediatR;
using MOM.Application.DTOs.MaterialClass.Requests;
using MOM.Application.DTOs.MaterialDefinition.Requests;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;

namespace MOM.Application.Features.Material.Commands.AddMaterialDefinition
{
    public class AddMaterialDefinitionCommannd : AddMaterialDefinitionRequest, IRequest<BaseResult>
    {
       
    }
}
