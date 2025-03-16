using MOM.Domain.Common.EnumType;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    public partial class EquipmentClass
    {
        public string Description { get; set; }

        public EquipmentClass(string ID, string description) : this()
        {
            this.Id = Id;
            this.Description = description;
        }

        public async void PutIncludesPropertiesOf(List<string> childClassDtId)
        {
            var haveDtIds = this.IncludesPropertiesOf.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childClassDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childClassDtId);
            foreach (var item in deleteDtIds)
            {
                this.IncludesPropertiesOf.Remove(item);
            }
            foreach (var item in notHaveDtIds)
            {
                this.IncludesPropertiesOf.Add(new Common.Relationship.isa95.EquipmentClass.EquipmentClassIncludesPropertiesOfRelationship(this.DtId, item));
            }
        }
        public async void PutIsMadeUpOf(List<string> childClassDtId)
        {
            var haveDtIds = this.IsMadeUpOf.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childClassDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childClassDtId);
            foreach (var item in deleteDtIds)
            {
                this.IsMadeUpOf.Remove(item);
            }
            foreach (var item in notHaveDtIds)
            {
                this.IsMadeUpOf.Add(new Common.Relationship.isa95.EquipmentClass.EquipmentClassIsMadeUpOfRelationship(this.DtId, item));
            }
        }

        public void Update(string iD, string? description, EquipmentClassEquipmentLevel? equipmentLevel)
        {
            this.Id = Id;
            this.Description = description;
            this.EquipmentLevel = equipmentLevel;
        }

        public void HasPropertiesOfAddTarget(EquipmentClassProperty equipmentClassProperty)
        {
            this.HasPropertiesOf.Add(new Common.Relationship.isa95.EquipmentClass.EquipmentClassHasPropertiesOfRelationship(this,equipmentClassProperty));
        }

        public void Delete()
        {
            foreach(var item in HasPropertiesOf)
            {
                item.Target.Delete();
            }
            this.HierarchyScopeRel.Clear();
            this.IncludesPropertiesOf.Clear();
            this.HasPropertiesOf.Clear();
            this.IsDelete = true;
        }
    }
}