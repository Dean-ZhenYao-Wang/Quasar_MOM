using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.AddEquipment
{
    public class AddEquipmentCommandHandler(IEquipmentRepository equipmentRepository, IUnitOfWork unitOfWork, IMediator mediator) : IRequestHandler<AddEquipmentCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddEquipmentCommand request, CancellationToken cancellationToken)
        {
            var equipment = request.ToEquipment();
            equipment.Id = string.IsNullOrWhiteSpace(request.Id)
                    ? await mediator.Send(new GenerateCodeCommand { RuleId = "EquipmentId", ModelTypeName = " MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment,MOM.Domain" })
                    : request.Id;
            await equipmentRepository.AddAsync(equipment);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
