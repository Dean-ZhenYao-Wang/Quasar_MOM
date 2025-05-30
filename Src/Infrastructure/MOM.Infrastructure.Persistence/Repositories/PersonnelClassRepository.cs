﻿using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Interfaces.Repositories;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class PersonnelClassRepository(ApplicationDbContext dbContext) : GenericRepository<PersonnelClass>(dbContext), IPersonnelClassRepository
    {
        private readonly DbSet<PersonnelClassIncludesPropertiesOfRelationship> personnelClassIncludesPropertiesOfRelationships = dbContext.Set<PersonnelClassIncludesPropertiesOfRelationship>();
        private readonly DbSet<PersonnelClassHasPropertiesOfRelationship> personnelClassHasPropertiesOfRelationships = dbContext.Set<PersonnelClassHasPropertiesOfRelationship>();
        private readonly DbSet<PersonnelClassHierarchyScopeRelRelationship> personnelClassHierarchyScopeRelRelationships = dbContext.Set<PersonnelClassHierarchyScopeRelRelationship>();

        public async Task AddAsync(PersonnelClass model, Guid? sourceDtId)
        {
            await AddAsync(model);
            await personnelClassIncludesPropertiesOfRelationships.AddAsync(new PersonnelClassIncludesPropertiesOfRelationship(sourceDtId, model.DtId));
        }

        public async Task DeleteAsync(Guid[] dtIds)
        {
            await this.ExecuteUpdateAsync(m => dtIds.Contains(m.DtId), setters => setters.SetProperty(pc => pc.IsDelete, true));
        }

        public async Task<List<OrgResponse>> GetOrgTreeAsync(Guid? sourceDtId)
        {
            List<OrgResponse> returnModel = null;

            //if (sourceDtId != null && sourceDtId != Guid.Empty)
            //{
            //    returnModel = await personnelClassIncludesPropertiesOfRelationships.Where(m => m.SourceId == sourceDtId.Value)
            //        .Select(m => m.Target.ToOrgResponse())
            //        .ToListAsync();
            //}
            //else
            //{
            //    returnModel = await this.DbSet.Where(m => m.Description.Equals("组织")
            //    &&
            //        !personnelClassIncludesPropertiesOfRelationships.Where(r=>r.TargetId==m.DtId).Any())
            //         .Select(m => m.ToOrgResponse())
            //         .ToListAsync();
            //}

            return returnModel;
        }
    }
}