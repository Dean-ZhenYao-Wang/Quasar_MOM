using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.PersonnelClassProperty;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    public partial class PersonnelClassProperty
    {

        public PersonnelClassProperty(ResourceClassPropertyPropertyType propertyType, string ID, string? description = null, string? value = null, string? valueUnitOfMeasure = null) : base(propertyType, ID,description, value, valueUnitOfMeasure) { }

        public void Delete()
        {
            foreach (var item in Contains.Where(m => m.Target.IsDelete == false))
            {
                item.Target.Delete();
            }
            this.IsDelete = true;
        }

        public void ContainsAddTarget(string targetDtId)
        {
            this.Contains.Add(new PersonnelClassPropertyContainsRelationship(this.DtId, targetDtId));
        }
        public void ContainsAddTarget(PersonnelClassProperty target)
        {
            this.Contains.Add(new PersonnelClassPropertyContainsRelationship(this, target));
        }
    }
}