using MediatR;
using MOM.Application.Features.PersonnelClass.Commands.AddPsitoion;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Commands.UpdatePosition
{
    public class UpdatePositionCommand : AddPositionCommand, IRequest<BaseResult>
    {
    }
}
