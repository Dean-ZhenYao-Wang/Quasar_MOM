using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.DeleteMenu
{
    /// <summary>
    ///
    /// </summary>
    public class DeleteMenuCommand : IRequest<BaseResult>
    {
        /// <summary>
        ///
        /// </summary>
        public Guid[] DtIds { get; set; } = [];
    }
}