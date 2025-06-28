using MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.PhysicalAssetAndEquipment
{
    /// <summary>
    /// 
    /// </summary>
    public static class PhysicalAssetAndEquipmentException
    {
        public static void Update(this Equipment old, UpdateEquipmentRequest request)
        {
            if (!string.IsNullOrWhiteSpace(request.Id))
                old.Id = request.Id;
            old.Name = request.Name;
            old.Property = request.Property;
            old.Description = request.Description;
            old.EquipmentLevel = request.EquipmentLevel;

            old.DefinedBy.RemoveAll(x => !request.DefinedByDtId.Contains(x.TargetId));
            old.Property = request.Property;
            old.HierarchyScopeRelDtId = request.HierarchyScopeRelDtId;
            old.ResponsibleDtId = request.ResponsibleDtId;
            if (old.Status != Domain.Common.EnumType.EquipmentStatusType.启用 && request.Status == Domain.Common.EnumType.EquipmentStatusType.启用)
                old.EnabledTime = DateTime.Now;
            old.Status = request.Status;
            old.Supplier = request.Supplier;
            old.Specification = request.Specification;
            old.FactoryNumber = request.FactoryNumber;
        }
    }
}
