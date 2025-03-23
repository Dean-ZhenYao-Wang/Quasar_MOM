namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    public partial class PersonProperty
    {
        public PersonProperty(Guid ID, string description, string value, string valueUnitOfMeasure, Guid? mapToDtId) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
            if (mapToDtId != null)
            {
                this.MapsTo.Add(new Common.Relationship.isa95.PersonProperty.PersonPropertyMapsToRelationship(this.DtId, mapToDtId.Value));
            }
        }

        public void Delete()
        {
            foreach (var item in Contains)
            {
                item.Target.Delete();
            }
            this.Contains.Clear();
            this.MapsTo.Clear();
            this.IsDelete = true;
        }


        public void ContainsAddTarget(PersonProperty personProperty)
        {
            this.Contains.Add(new Common.Relationship.isa95.PersonProperty.PersonPropertyContainsRelationship(this, personProperty));
        }


        public void Update(string iD, string? description, string? value, string? valueUnitOfMeasure)
        {
            this.Id = Id;
            this.Description = description ?? string.Empty;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
        }
    }
}