using MOM.Infrastructure.Persistence.Contexts;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Seeds
{
    public static class DefaultData
    {
        public static async Task SeedAsync(ApplicationDbContext applicationDbContext)
        {
            //if (!await applicationDbContext.Products.AnyAsync())
            //{
            //    await applicationDbContext.SaveChangesAsync();
            //}
        }
    }
}
