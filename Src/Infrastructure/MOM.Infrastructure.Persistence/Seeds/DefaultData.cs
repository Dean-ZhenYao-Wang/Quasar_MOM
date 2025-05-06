using Microsoft.EntityFrameworkCore;
using MOM.Application.Infrastructure.Extensions;
using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using MOM.Domain.isa95.EquipmentHierarchy;
using MOM.Domain.Permission;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Seeds
{
    public static class DefaultData
    {
        public static async Task SeedAsync(ApplicationDbContext applicationDbContext, Application.Wrappers.EnterpriseSettings enterpriseSettings)
        {
            if (!await applicationDbContext.Person.AnyAsync())
            {
                var enterprise = new HierarchyScope(HierarchyScopeEquipmentLevel.Enterprise, "0000", "企业",true);
                applicationDbContext.HierarchyScopes.Add(enterprise);

                //var enterprise = new Enterprise(enterpriseSettings.Name, enterpriseSettings.Description, true, enterpriseSettings.Address);
                //applicationDbContext.Enterprises.Add(enterprise);

                PersonnelClass qiye= new PersonnelClass(enterpriseSettings.Name, "部门", enterprise);
                applicationDbContext.PersonnelClasses.Add(qiye);

                PersonnelClass personnelClass = new PersonnelClass("超级管理员", "角色", enterprise);
                applicationDbContext.PersonnelClasses.Add(personnelClass);

                Person admin = new Person("admin", "管理员", PersonWorkStatus.在职);
                admin.PassWord = "Sam@123456".Sha1Signature().Sha1Signature(admin.DtId.ToString());
                admin.SecurityStamp = Guid.NewGuid().ToString();
                admin.DefinedByAddTarget(personnelClass.DtId);
                applicationDbContext.Person.Add(admin);

                await applicationDbContext.SaveChangesAsync();
            }
            if (!await applicationDbContext.Menus.AnyAsync())
            {
                var menu = new Menu()
                {
                    Id = "0000",
                    Name = "系统配置",
                    Path = string.Empty,
                    Depth = 0,
                    Children = new List<Menu>()
                    {
                        new Menu
                        {
                            Id = "0000-0001",
                            Name = "菜单管理",
                            Path = "/system/menu",
                            Depth = 1,
                        }
                    }
                };
                applicationDbContext.Menus.Add(menu);
                var menu2 = new Menu()
                {
                    Id = "0001",
                    Name = "基础数据",
                    Path = string.Empty,
                    Depth = 0,
                    Children = new List<Menu>()
                    {
                        new Menu
                        {
                            Id = "0001-0001",
                            Name = "组织架构",
                            Path = "/org/org",
                            Depth = 1,
                        },
                        new Menu
                        {
                            Id = "0001-0002",
                            Name = "岗位",
                            Path = "/system/menu",
                            Depth = 1,
                        }
                    }
                };
                applicationDbContext.Menus.Add(menu);
                await applicationDbContext.SaveChangesAsync();
            }
        }
    }
}
