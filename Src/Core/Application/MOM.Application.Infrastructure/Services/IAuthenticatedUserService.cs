namespace MOM.Application.Infrastructure.Services
{
    public interface IAuthenticatedUserService
    {
        string DtId { get; }
        string UserName { get; }
        List<string> Roles { get; }
    }
}