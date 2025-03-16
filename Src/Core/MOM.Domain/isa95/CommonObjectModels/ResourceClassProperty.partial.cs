using MOM.Domain.Common.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Domain.isa95.CommonObjectModels
{
    public partial class ResourceClassProperty
    {
        public string? Description { get; set; }
        public ResourceClassProperty(ResourceClassPropertyPropertyType propertyType, string ID, string? description = null, string? value = null, string? valueUnitOfMeasure = null) : this()
        {
            PropertyType = propertyType;
            this.Id = Id;
            Description = description;
            Value = value;
            ValueUnitOfMeasure = valueUnitOfMeasure;
        }

        public virtual void Update(ResourceClassPropertyPropertyType propertyType, string iD, string description, string value, string valueUnitOfMeasure)
        {
            this.PropertyType = propertyType;
            this.Id = Id;
            this.Description = description;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
        }
    }
}
