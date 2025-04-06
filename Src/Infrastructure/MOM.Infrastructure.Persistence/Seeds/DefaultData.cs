using Microsoft.EntityFrameworkCore;
using MOM.Application.Infrastructure.Extensions;
using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Seeds
{
    public static class DefaultData
    {
        public static async Task SeedAsync(ApplicationDbContext applicationDbContext)
        {
            if (!await applicationDbContext.Person.AnyAsync())
            {
                PersonnelClass personnelClass = new PersonnelClass("超级管理员","角色");
                applicationDbContext.PersonnelClasses.Add(personnelClass);
                //await applicationDbContext.SaveChangesAsync();

                Person admin = new Person("admin", "管理员", PersonWorkStatus.在职);
                admin.PassWord="Sam@123456".Sha1Signature().Sha1Signature(admin.DtId.ToString());
                admin.SecurityStamp = Guid.NewGuid().ToString();
                admin.DefinedByAddTarget(personnelClass.DtId);
                applicationDbContext.Person.Add(admin);

                await applicationDbContext.SaveChangesAsync();
            }
        }
    }
}
