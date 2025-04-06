using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace MOM.Application.Infrastructure.Services
{
    public class AuthenticatedUserService(IHttpContextAccessor httpContextAccessor) : IAuthenticatedUserService
    {
        public string DtId { get; } = httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
        public string UserName { get; } = httpContextAccessor.HttpContext?.User.Identity?.Name;
        public string[] DefinedBy { get; } = httpContextAccessor.HttpContext?.User.FindFirstValue("DefinedBy")?.Split(',') ?? Array.Empty<string>();
    }
}
