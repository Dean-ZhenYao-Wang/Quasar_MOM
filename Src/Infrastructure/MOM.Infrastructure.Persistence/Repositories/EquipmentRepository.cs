using MOM.Application.Interfaces.Repositories;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;
using MOM.Infrastructure.Persistence.Contexts;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class EquipmentRepository(ApplicationDbContext dbContext) : GenericRepository<Equipment>(dbContext)
        , IEquipmentRepository
    {
    }
}