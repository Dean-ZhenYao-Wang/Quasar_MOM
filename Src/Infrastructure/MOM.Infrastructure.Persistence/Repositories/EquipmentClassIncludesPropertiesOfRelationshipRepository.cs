using MOM.Application.Interfaces.Repositories;
using MOM.Domain.Common.Relationship.isa95.EquipmentClass;
using MOM.Infrastructure.Persistence.Contexts;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class EquipmentClassIncludesPropertiesOfRelationshipRepository(ApplicationDbContext dbContext) : GenericRepository<EquipmentClassIncludesPropertiesOfRelationship>(dbContext), IEquipmentClassIncludesPropertiesOfRelationshipRepository
    {
        
    }
}