using MOM.Application.Interfaces.Repositories;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using MOM.Domain.Products.Entities;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class PersonRepository(ApplicationDbContext dbContext) : GenericRepository<Person>(dbContext), IPersonRepository
    {
    }
}
