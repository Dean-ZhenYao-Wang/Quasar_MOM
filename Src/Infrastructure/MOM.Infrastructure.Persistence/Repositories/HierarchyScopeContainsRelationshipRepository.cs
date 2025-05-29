using Azure.Core;
using Json.Path;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{

    public class HierarchyScopeContainsRelationshipRepository(ApplicationDbContext dbContext)
        : RelationshipRepository<HierarchyScopeContainsRelationship,HierarchyScope,HierarchyScope>(dbContext),
        IHierarchyScopeContainsRelationshipRepository
    {
    }
}