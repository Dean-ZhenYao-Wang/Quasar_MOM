using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace MOM.Application.Infrastructure.Services
{
    public class AuthenticatedUserService(IHttpContextAccessor httpContextAccessor) : IAuthenticatedUserService
    {
        public string DtId { get; } = httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
        public string UserName { get; } = httpContextAccessor.HttpContext?.User.Identity?.Name;
        public List<string> Roles { get; } = httpContextAccessor.HttpContext?.User.FindFirstValue("Roles")?.Split(',').ToList() ?? new List<string>();
    }
}