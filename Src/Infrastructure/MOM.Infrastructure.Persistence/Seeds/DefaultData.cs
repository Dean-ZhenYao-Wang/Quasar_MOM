﻿using Microsoft.EntityFrameworkCore;
using MOM.Application.Infrastructure.Extensions;
using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Seeds
{
    public static class DefaultData
    {
        public static async Task SeedAsync(ApplicationDbContext applicationDbContext, Application.Wrappers.EnterpriseSettings enterpriseSettings)
        {
            if (!await applicationDbContext.Person.AnyAsync())
            {
                Person admin = new Person("admin", "超级管理员", PersonWorkStatus.Employed);
                admin.PassWord = "Sam@123456".Sha1Signature().Sha1Signature(admin.DtId.ToString());
                admin.SecurityStamp = Guid.NewGuid().ToString();
                applicationDbContext.Person.Add(admin);

                var enterprise = new HierarchyScope(HierarchyScopeEquipmentLevel.Enterprise, "0000", enterpriseSettings.Name, enterpriseSettings.Address, true, "系统购买者");
                applicationDbContext.HierarchyScopes.Add(enterprise);
                applicationDbContext.HierarchyScopeContainsRelationship.Add(new HierarchyScopeContainsRelationship(null, enterprise.DtId));

                PersonnelClass personnelClass = new PersonnelClass("超级管理员", "角色", enterprise);
                applicationDbContext.PersonnelClasses.Add(personnelClass);
                applicationDbContext.PersonnelClassIncludesPropertiesOfRelationships.Add(new PersonnelClassIncludesPropertiesOfRelationship(null, personnelClass.DtId));

                applicationDbContext.PersonnelClassPermission.Add(new Domain.Permission.PersonnelClassPermission()
                {
                    PersonnelClassDtId = personnelClass.DtId,
                    MenuButtonId = "*:*:*"
                });

                admin.HierarchyScopeRel.Add(new Domain.Common.Relationship.isa95.Person.PersonHierarchyScopeRelRelationship(admin.DtId, enterprise.DtId));
                admin.DefinedByAddTarget(new Guid[] { personnelClass.DtId }, "角色");

                await applicationDbContext.SaveChangesAsync();
            }
            //if (!await applicationDbContext.Menus.AnyAsync())
            //{
            //    var menu = new Menu()
            //    {
            //        Id = "0000",
            //        Name = "系统配置",
            //        Path = string.Empty,
            //        Depth = 0,
            //        Children = new List<Menu>()
            //        {
            //            new Menu
            //            {
            //                Id = "0000-0001",
            //                Name = "菜单管理",
            //                Path = "/system/menu",
            //                Depth = 1,
            //            }
            //        }
            //    };
            //    applicationDbContext.Menus.Add(menu);
            //    var menu2 = new Menu()
            //    {
            //        Id = "0001",
            //        Name = "基础数据",
            //        Path = string.Empty,
            //        Depth = 0,
            //        Children = new List<Menu>()
            //        {
            //            new Menu
            //            {
            //                Id = "0001-0001",
            //                Name = "组织架构",
            //                Path = "/org/org",
            //                Depth = 1,
            //            },
            //            new Menu
            //            {
            //                Id = "0001-0002",
            //                Name = "岗位",
            //                Path = "/system/menu",
            //                Depth = 1,
            //            }
            //        }
            //    };
            //    applicationDbContext.Menus.Add(menu);
            //    await applicationDbContext.SaveChangesAsync();
            //}
        }
    }
}