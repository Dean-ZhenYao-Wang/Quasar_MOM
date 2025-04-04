using MediatR;
using MOM.Application.DTOs.Personnel.Requests;
using MOM.Application.DTOs.Resource.Responses;
using MOM.Application.Wrappers;
using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MOM.Application.Features.Personnel.Commands.AddPerson
{
    public class AddPersonCommand : AddPersonRequest,IRequest<BaseResult>
    {
    }
}
