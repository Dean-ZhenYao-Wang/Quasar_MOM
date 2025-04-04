using System.Collections.Generic;

namespace MOM.Application.DTOs.Account.Responses
{
    public class AuthenticationResponse
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public IList<string> Roles { get; set; }
        public string JwToken { get; set; }
    }
}
