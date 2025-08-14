using MOM.Application.Interfaces.Repositories;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;
using MOM.Infrastructure.Persistence.Contexts;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class MaterialDefinitionRepository(ApplicationDbContext dbContext) : GenericRepository<MaterialDefinition>(dbContext), IMaterialDefinitionRepository { }
}