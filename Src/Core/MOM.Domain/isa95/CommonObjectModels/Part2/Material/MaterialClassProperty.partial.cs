using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.MaterialClassProperty;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    public partial class MaterialClassProperty
    {
        public string Description { get; set; }

        public MaterialClassProperty(string ID, string description, ResourceClassPropertyPropertyType propertyType, string value, string valueUnitOfMeasure) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.PropertyType = propertyType;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
        }

        public void Delete()
        {
            foreach (var child in Contains)
            {
                child.Target.Delete();
            }
            this.IsDelete = true;
        }

        public void ContainsAddTarget(MaterialClassProperty target)
        {
            this.Contains.Add(new MaterialClassPropertyContainsRelationship(this, target));
        }

        public void Update(string iD, string description, ResourceClassPropertyPropertyType propertyType, string value, string valueUnitOfMeasure)
        {
            this.Id = Id;
            this.Description = description;
            this.PropertyType = propertyType;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
        }
    }
}