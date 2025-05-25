using Microsoft.EntityFrameworkCore;
using MOM.Application.Infrastructure.Extensions;
using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
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

                admin.HierarchyScopeRelDtId = enterprise.DtId;
                admin.DefinedByAddTarget(new Guid[] { personnelClass.DtId }, "角色");


                List<Menu> menus = new List<Menu>();

                Menu system = new Menu()
                {
                    Id = "001",
                    Depth = 0,
                    Name = "系统管理",
                    Children = new System.Collections.Generic.List<Menu>
                    {
                        new Menu()
                        {
                            Id="001-1",
                            Depth=1,
                            Name="菜单管理",
                            Path="/system/menu",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        }
                    }
                };
                menus.Add(system);

                Menu org = new Menu()
                {
                    Id = "002",
                    Depth = 0,
                    Name = "基础资料",
                    Children = new List<Menu>
                    {
                        new Menu
                        {
                            Id="002-1",
                            Depth=1,
                            Name="组织管理",
                            Path="/org/org",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="002-2",
                            Depth=1,
                            Name="班组",
                            Path="/org/team",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="002-3",
                            Depth=1,
                            Name="职位",
                            Path="/org/position",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="002-4",
                            Depth=1,
                            Name="员工",
                            Path="/personnel",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                    }
                };
                menus.Add(org);

                Menu productionModeling = new Menu()
                {
                    Id = "003",
                    Depth = 0,
                    Name = "生产建模",
                    Children = new List<Menu>()
                    {
                        new Menu
                        {
                            Id="003-1",
                            Depth=1,
                            Name="工厂管理",
                            Path="/productionModeling/factory",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="003-2",
                            Depth=1,
                            Name="车间管理",
                            Path="/productionModeling/workshop",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="003-3",
                            Depth=1,
                            Name="产线管理",
                            Path="/productionModeling/productionLine",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="003-4",
                            Depth=1,
                            Name="工位",
                            Path="/productionModeling/workstation",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                    }
                };
                menus.Add(productionModeling);

                Menu equipment = new Menu()
                {
                    Id = "004",
                    Depth = 0,
                    Name = "设备管理",
                    Children = new List<Menu>()
                    {
                        new Menu
                        {
                            Id="004-1",
                            Depth=1,
                            Name="设备类型",
                            Path="/equipment/equipmentClass",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="004-2",
                            Depth=1,
                            Name="设备",
                            Path="/equipment/equipment",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                    }
                };
                menus.Add(equipment);

                Menu warehouse = new Menu()
                {
                    Id = "005",
                    Depth = 0,
                    Name = "仓库管理",
                    Children = new List<Menu>()
                    {
                        new Menu
                        {
                            Id="005-1",
                            Depth=1,
                            Name="仓库",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="005-2",
                            Depth=1,
                            Name="库位",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="005-3",
                            Depth=1,
                            Name="库存",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                    }
                };
                menus.Add(warehouse);

                Menu material = new Menu()
                {
                    Id = "006",
                    Depth = 0,
                    Name = "物料管理",
                    Children = new List<Menu>()
                    {
                        new Menu
                        {
                            Id="006-1",
                            Depth=1,
                            Name="物料类型",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="006-2",
                            Depth=1,
                            Name="物料",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="006-3",
                            Depth=1,
                            Name="制造BOM（mBom）",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                    }
                };
                menus.Add(material);

                Menu segment = new Menu()
                {
                    Id = "007",
                    Depth = 0,
                    Name = "工艺管理",
                    Children = new List<Menu>()
                    {
                        new Menu
                        {
                            Id="007-1",
                            Depth=1,
                            Name="工艺路线",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="007-2",
                            Depth=1,
                            Name="工序",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                    }
                };
                menus.Add(segment);

                Menu product = new Menu()
                {
                    Id = "008",
                    Depth = 0,
                    Name = "产品管理",
                    Children = new List<Menu>()
                    {
                        new Menu
                        {
                            Id="008-1",
                            Depth=1,
                            Name="产品类型",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                        new Menu
                        {
                            Id="008-2",
                            Depth=1,
                            Name="产品",
                            Buttons=new System.Collections.Generic.List<Button>
                            {
                                new Button
                                {
                                    Id="system:menu:add",
                                    Name="新增"
                                },
                                new Button
                                {
                                    Id="system:menu:edit",
                                    Name="修改"
                                },
                                new Button
                                {
                                    Id="system:menu:delete",
                                    Name="删除"
                                }
                            }
                        },
                    }
                };
                menus.Add(product);

                applicationDbContext.Menus.AddRange(menus);

                await applicationDbContext.SaveChangesAsync();
            }
        }
    }
}