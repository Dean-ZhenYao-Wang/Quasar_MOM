using MOM.Application.Interfaces.Repositories;
using MOM.Domain.Common.Relationship.isa95.Equipment;
using MOM.Infrastructure.Persistence.Contexts;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class EquipmentDefinedByRelationshipRepository(ApplicationDbContext dbContext) : GenericRepository<EquipmentDefinedByRelationship>(dbContext), IEquipmentDefinedByRelationshipRepository { }
}