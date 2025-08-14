using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Material.Commands.AddMaterialClass
{
    public class AddMaterialClassCommanndHandler(IMaterialClassRepository materialClassRepository, IUnitOfWork unitOfWork, IMediator mediator) : IRequestHandler<AddMaterialClassCommannd, BaseResult>
    {
        public async Task<BaseResult> Handle(AddMaterialClassCommannd request, CancellationToken cancellationToken)
        {
            var materialClass = request.ToEquipmentClass();
            materialClass.Id = string.IsNullOrWhiteSpace(request.Id)
                    ? await mediator.Send(new GenerateCodeCommand { RuleId = "MaterialClassId", ModelTypeName = " MOM.Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass,MOM.Domain" })
                    : request.Id;
            await materialClassRepository.AddAsync(materialClass);

            return BaseResult.Ok();
        }
    }
}
