using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Infrastructure.Attribute
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TransactionalAttribute : ActionFilterAttribute
    {
    }
}
