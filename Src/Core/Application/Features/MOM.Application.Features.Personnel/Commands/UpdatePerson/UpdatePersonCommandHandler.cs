using MediatR;
using MOM.Application.DTOs.Resource.Responses;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.Linq;

namespace MOM.Application.Features.Personnel.Commands.UpdatePerson
{
    public class UpdatePersonCommandHandler(IPersonRepository personRepository, ITranslator translator) : IRequestHandler<UpdatePersonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = await personRepository.GetByIdAsync(request.DtId);

            if (person is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }

            person.Update(request.Id, request.Name, request.WorkStatus, request.Email, request.PhoneNumber, request.TeamOfGroupDtId, request.DepartmentDtId, request.PositionDtId_List, request.Description);
            var haveDtIds = person.HasValuesOf.Select(m => m.TargetId).ToList();
            人员特征列表在修改时的增删改处理(request.Properties, person, haveDtIds);
            return BaseResult.Ok();
        }
        private void 人员特征列表在修改时的增删改处理(IEnumerable<ResourcePropertyResponse> properties, Person person, List<Guid> haveDtIds)
        {
            var requestDtIds = properties.Select(m => m.dtId).ToList();
            var notHaveDtIds = requestDtIds.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(requestDtIds);
            foreach (var m in properties.Where(m => haveDtIds.Contains(m.dtId)))
            {
                var property = person.HasValuesOf.Where(m => m.TargetId.Equals(m.DtId)).FirstOrDefault().Target;
                property.Update(m.Id, m.Description, m.Value, m.ValueUnitOfMeasure);
                PropertyContiansUpdate(m, property);
            }
            foreach (var m in properties.Where(m => notHaveDtIds.Contains(m.dtId)))
            {
                person.HasValuesOfAddTarget(m.ToPersonProperty());
            }
            person.HasValuesOf.Remove(deleteDtIds);
        }
        private void PropertyContiansUpdate(ResourcePropertyResponse propertyViewModel, PersonProperty property)
        {
            var havePropertyDtIds = property.Contains.Select(m => m.TargetId).ToList();
            var requestPropertyDtIds = propertyViewModel.children.Select(m => m.dtId).ToList();
            var notPropertyHaveDtIds = requestPropertyDtIds.Except(havePropertyDtIds);
            var deletePropertyDtIds = havePropertyDtIds.Except(requestPropertyDtIds);
            foreach (var pm in propertyViewModel.children.Where(c => havePropertyDtIds.Contains(c.dtId)))
            {
                var childProperty = property.Contains.Where(pc => pc.TargetId.Equals(pm.dtId)).FirstOrDefault().Target;
                childProperty.Update(pm.Id, pm.Description, pm.Value, pm.ValueUnitOfMeasure);
                PropertyContiansUpdate(pm, childProperty);
            }

            foreach (var p in propertyViewModel.children.Where(c => notPropertyHaveDtIds.Contains(c.dtId)))
            {
                property.ContainsAddTarget(p.ToPersonProperty());
            }
            property.Contains.Remove(deletePropertyDtIds);
        }
    }
}
