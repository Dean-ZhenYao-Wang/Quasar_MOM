using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope.Responses;

namespace MOM.Application.DTOs.HierarchyScope
{
    public static class OrgException
    {
        public static TreeNode<OrgResponse> ToOrgTreeResponse(this Domain.isa95.CommonObjectModels.HierarchyScope hierarchyScope, Guid? sourceDtId = null)
        {
            TreeNode<OrgResponse> OrgResponse = new()
            {
                key = hierarchyScope.DtId.ToString(),
                label = hierarchyScope.Name,
                data = new OrgResponse
                {
                    DtId = hierarchyScope.DtId,
                    Id = hierarchyScope.Id,
                    Name = hierarchyScope.Name,
                    ResponsibleDtId = hierarchyScope.ResponsibleDtId,
                    EquipmentLevel = hierarchyScope.EquipmentLevel,
                    Active = hierarchyScope.Active,
                    Description = hierarchyScope.Description,
                    SourceDtId = sourceDtId,
                    Address = hierarchyScope.Address
                },
                children = hierarchyScope.Contains.Select(m => m.Target.ToOrgTreeResponse(m.DtId)).OrderBy(m => m.data.Id).ToList(),
            };

            return OrgResponse;
        }

        public static OrgResponse ToOrgItemResponse(this Domain.isa95.CommonObjectModels.HierarchyScope hierarchyScope, Guid? sourceDtId = null, string sourceName = "")
        {
            OrgResponse OrgResponse = new()
            {
                DtId = hierarchyScope.DtId,
                Id = hierarchyScope.Id,
                Name = hierarchyScope.Name,
                ResponsibleDtId = hierarchyScope.ResponsibleDtId,
                EquipmentLevel = hierarchyScope.EquipmentLevel,
                Active = hierarchyScope.Active,
                Description = hierarchyScope.Description,
                SourceDtId = sourceDtId,
                Address = hierarchyScope.Address,
                SourceName = sourceName
            };

            return OrgResponse;
        }
    }
}