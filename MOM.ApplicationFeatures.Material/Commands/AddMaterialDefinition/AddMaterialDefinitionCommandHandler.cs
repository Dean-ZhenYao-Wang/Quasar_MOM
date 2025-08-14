using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Material.Commands.AddMaterialDefinition
{
    public class AddMaterialDefinitionCommandHandler(IMaterialDefinitionRepository materialDefinitionRepository, IUnitOfWork unitOfWork, IMediator mediator) : IRequestHandler<AddMaterialDefinitionCommannd, BaseResult>
    {
        public async Task<BaseResult> Handle(AddMaterialDefinitionCommannd request, CancellationToken cancellationToken)
        {
            request.Id = string.IsNullOrWhiteSpace(request.Id)
                    ? await mediator.Send(new GenerateCodeCommand { RuleId = "MaterialDefinitionId", ModelTypeName = " MOM.Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition,MOM.Domain" })
                    : request.Id;
            var materialDefinition = request.ToMaterialDefinition();
            await materialDefinitionRepository.AddAsync(materialDefinition);

            return BaseResult.Ok();
        }
    }
}
