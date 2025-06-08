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
        : RelationshipRepository<HierarchyScopeContainsRelationship, HierarchyScope, HierarchyScope>(dbContext),
        IHierarchyScopeContainsRelationshipRepository
    {
        public async Task<PagedResponse<OrgResponse>> GetEnterpriseListAsync(string id, string name, int page, int pageSize)
        {
            var query = this
                .Include(m => m.Target)
                .ThenInclude(t => t.Responsible)
                .Include(m => m.Target)
                .ThenInclude(t => t.Source)
                .Where(m => m.Target.EquipmentLevel == HierarchyScopeEquipmentLevel.Enterprise && m.Depth == 0)
                .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Target.Id.Contains(id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Target.Name.Contains(name) : true)
                .Select(m => new OrgResponse
                {
                    Active = m.Target.Active,
                    Address = m.Target.Address,
                    Description = m.Target.Description,
                    SourceName = m.Target.Source.Name,
                    SourceDtId = m.Target.SourceDtId,
                    DtId = m.Target.DtId,
                    EquipmentLevel = m.Target.EquipmentLevel,
                    FullPath = m.Target.FullPath,
                    Id = m.Target.Id,
                    Name = m.Target.Name,
                    ResponsibleDtId = m.Target.ResponsibleDtId,
                    ResponsibleName = m.Target.ResponsibleName,
                });

            return await this.PagedAsync(query, page, pageSize);
        }

        public async Task<PagedResponse<OrgResponse>> GetFactoryListAsync(string id, string name, int page, int pageSize)
        {
            var query = this
                .Include(m => m.Target)
                .ThenInclude(t => t.Responsible)
                .Include(m => m.Target)
                .ThenInclude(t => t.Source)
                .Where(m => m.Target.EquipmentLevel == HierarchyScopeEquipmentLevel.Site && m.Depth == 0)
                .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Target.Id.Contains(id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Target.Name.Contains(name) : true)
                .Select(m => new OrgResponse
                {
                    Active = m.Target.Active,
                    Address = m.Target.Address,
                    Description = m.Target.Description,
                    SourceName = m.Target.Source.Name,
                    SourceDtId = m.Target.SourceDtId,
                    DtId = m.Target.DtId,
                    EquipmentLevel = m.Target.EquipmentLevel,
                    FullPath = m.Target.FullPath,
                    Id = m.Target.Id,
                    Name = m.Target.Name,
                    ResponsibleDtId = m.Target.ResponsibleDtId,
                    ResponsibleName = m.Target.ResponsibleName,
                });

            return await this.PagedAsync(query, page, pageSize);
        }

        public async Task<PagedResponse<OrgResponse>> GetOrgListAsync(Guid? sourceDtId, string id, string name, int page, int pageSize)
        {
            var query = this
                .Include(m => m.Target)
                .ThenInclude(t => t.Responsible)
                .Include(m => m.Target)
                .ThenInclude(t => t.Source)
                .Where(m => sourceDtId == null ? m.Depth == 0 : m.SourceId == sourceDtId && m.Depth == 1)
                .Where(m => !string.IsNullOrWhiteSpace(id) ? m.Target.Id.Contains(id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(name) ? m.Target.Name.Contains(name) : true)
                .OrderBy(m=>m.Target.Id)
                .Select(m => new OrgResponse
                {
                    Active = m.Target.Active,
                    Address = m.Target.Address,
                    Description = m.Target.Description,
                    SourceName = m.Target.Source.Name,
                    SourceDtId = m.Target.SourceDtId,
                    DtId = m.Target.DtId,
                    EquipmentLevel = m.Target.EquipmentLevel,
                    FullPath = m.Target.FullPath,
                    Id = m.Target.Id,
                    Name = m.Target.Name,
                    ResponsibleDtId = m.Target.ResponsibleDtId,
                    ResponsibleName = m.Target.ResponsibleName,
                });

            return await this.PagedAsync(query, page, pageSize);
        }
    }
}