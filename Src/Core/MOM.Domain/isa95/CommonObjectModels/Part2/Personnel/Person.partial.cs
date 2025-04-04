using Microsoft.AspNetCore.Identity;
using MOM.Domain.Common.EnumType;
using System.Text.Json.Serialization;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    public partial class Person
    {
        public string? Description { get; set; }
        /// <summary>
        /// 在职\休假\离职
        /// </summary>
        public PersonWorkStatus WorkStatus { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public Person(string Id, string name, PersonWorkStatus workStatus, string? email = null, string? phoneNumber = null, Guid? teamOfGroupDtId = null, Guid? departmentDtId = null, IEnumerable<Guid>? positionDtId_List = null, string? description = null) : this()
        {
            this.Id = Id;
            this.WorkStatus = workStatus;
            this.Description = description;
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            if (teamOfGroupDtId != null)
            {
                this.DefinedByAddTarget(teamOfGroupDtId.Value);
            }
            if (departmentDtId != null)
            {
                this.DefinedByAddTarget(departmentDtId.Value);
            }
            if (positionDtId_List != null)
            {
                foreach (var positionDtId in positionDtId_List)
                {
                    this.DefinedByAddTarget(positionDtId);
                }
            }
        }

        public void Update(string ID, string name, PersonWorkStatus workStatus, string? email = null, string? phoneNumber = null, Guid? teamOfGroupDtId = null, Guid? departmentDtId = null, IEnumerable<Guid>? positionDtId_List = null, string? description = null)
        {
            this.Id = Id;
            this.WorkStatus = workStatus;
            this.Description = description;
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            foreach (var item in DefinedBy)
            {
                DefinedBy.Remove(item);
            }
            if (teamOfGroupDtId != null)
            {
                this.DefinedByAddTarget(teamOfGroupDtId.Value);
            }
            if (departmentDtId != null)
            {
                this.DefinedByAddTarget(departmentDtId.Value);
            }
            if (positionDtId_List != null)
            {
                foreach (var positionDtId in positionDtId_List)
                {
                    this.DefinedByAddTarget(positionDtId);
                }
            }

        }

        private void DefinedByAddTarget(Guid teamOfGroupDtId)
        {
            this.DefinedBy.Add(new Common.Relationship.isa95.Person.PersonDefinedByRelationship(this.DtId, teamOfGroupDtId));
        }

        public void Delete()
        {
            this.DefinedBy.Clear();
            foreach (var item in HasValuesOf)
            {
                item.Target.Delete();
            }
            this.HasValuesOf.Clear();
            this.HierarchyScopeRel.Clear();
            this.OperationalLocationRel.Clear();
            this.IsDelete = true;
        }


        public void HasValuesOfAddTarget(PersonProperty personProperty)
        {
            this.HasValuesOf.Add(new Common.Relationship.isa95.Person.PersonHasValuesOfRelationship(this, personProperty));
        }
    }
}