using MediatR;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.DeleteButton
{
    /// <summary>
    ///
    /// </summary>
    public class DeleteButtonCommand : IRequest<BaseResult>
    {
        /// <summary>
        ///
        /// </summary>
        public Guid[] DtIds { get; set; } = [];
    }
}