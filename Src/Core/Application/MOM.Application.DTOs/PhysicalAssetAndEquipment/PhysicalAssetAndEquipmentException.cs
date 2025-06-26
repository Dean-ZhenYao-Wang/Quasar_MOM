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
            old.DefinedBy.RemoveAll(x => true);
            foreach (var item in request.DefinedBy)
            {
                old.DefinedBy.Add(new Domain.Common.Relationship.isa95.Equipment.EquipmentDefinedByRelationship(old.DtId, item));
            }
            old.Property = request.Property;
            old.HierarchyScopeRelDtId = request.HierarchyScopeRelDtId;
            old.ResponsibleDtId = request.ResponsibleDtId;
            old.Status = request.Status;
            old.Supplier = request.Supplier;
            old.Specification = request.Specification;
            old.FactoryNumber = request.FactoryNumber;
        }
    }
}
