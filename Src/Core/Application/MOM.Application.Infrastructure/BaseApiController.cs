using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MOM.Application.Infrastructure.Filters;

namespace MOM.Application.Infrastructure
{
    [ApiController]
    [ApiResultFilter]
    [Authorize]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public abstract class BaseApiController : ControllerBase
    {
        private IMediator? _mediator; // Mark _mediator as nullable to address CS8601

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>()
            ?? throw new InvalidOperationException("IMediator service is not registered."); // Add null check and exception to address CS8603
    }
}