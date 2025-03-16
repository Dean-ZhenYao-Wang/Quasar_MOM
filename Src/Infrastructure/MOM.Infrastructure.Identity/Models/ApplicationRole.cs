using System;
using Microsoft.AspNetCore.Identity;

namespace MOM.Infrastructure.Identity.Models
{
    public class ApplicationRole(string name) : IdentityRole<Guid>(name)
    {
    }
}
