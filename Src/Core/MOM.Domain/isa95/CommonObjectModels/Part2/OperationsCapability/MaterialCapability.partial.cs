using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.MaterialCapability;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    public partial class MaterialCapability
    {
        public string Description { get; set; }

        public MaterialCapability(string description, MaterialClass materialClass, MaterialCapabilityCapabilityType capabilityType, DateTime startTime, DateTime endTime) : this()
        {
            this.Description = description;
            if (materialClass != null && !this.CorrespondsToClass.Targets.Any(m => m.DtId.Equals(materialClass.DtId)))
            {
                this.CorrespondsToClass.Add(new MaterialCapabilityCorrespondsToClassRelationship(this, materialClass));
            }
            this.CapabilityType = capabilityType;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
    }
}