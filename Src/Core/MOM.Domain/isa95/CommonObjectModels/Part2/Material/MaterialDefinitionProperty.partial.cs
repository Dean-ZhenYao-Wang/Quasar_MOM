using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.MaterialDefinitionProperty;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    public partial class MaterialDefinitionProperty
    {
        public string Description { get; set; }

        public MaterialDefinitionProperty(string ID, string description, string value, string valueUnitOfMeasure, MaterialDefinitionPropertyPropertyType propertyPropertyType = MaterialDefinitionPropertyPropertyType.defaultType) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
            this.PropertyType = propertyPropertyType;
        }

        public void ContainsAddTarget(Guid targetDtId)
        {
            this.Contains.Add(new MaterialDefinitionPropertyContainsRelationship(this.DtId, targetDtId));
        }

        public void MapsToAddTarget(Guid targetDtId)
        {
            this.MapsTo.Add(new MaterialDefinitionPropertyMapsToRelationship(this.DtId, targetDtId));
        }

        public void Update(string iD, string? description, string value, string valueUnitOfMeasure, MaterialDefinitionPropertyPropertyType propertyPropertyType)
        {
            this.Id = Id;
            this.Description = description;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
            this.PropertyType = propertyPropertyType;
        }

        public void MapsToClear()
        {
            this.MapsTo.Clear();
        }

        public void Delete()
        {
            foreach (var item in Contains.Targets.Where(m => m.IsDelete == false))
            {
                item.Delete();
            }
            this.IsDelete = true;
        }
    }
}