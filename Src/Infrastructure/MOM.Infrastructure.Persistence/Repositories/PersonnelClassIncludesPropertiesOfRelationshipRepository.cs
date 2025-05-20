using MOM.Application.Interfaces.Repositories;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
using MOM.Infrastructure.Persistence.Contexts;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class PersonnelClassIncludesPropertiesOfRelationshipRepository(ApplicationDbContext dbContext):GenericRepository<PersonnelClassIncludesPropertiesOfRelationship>(dbContext), IPersonnelClassIncludesPropertiesOfRelationshipRepository
    {

    }
}
