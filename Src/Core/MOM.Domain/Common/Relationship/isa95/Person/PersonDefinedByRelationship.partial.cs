using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.Person
{
    public partial class PersonDefinedByRelationship
    {
        [JsonIgnore]
        [ForeignKey(nameof(SourceId))]
        public virtual Domain.isa95.CommonObjectModels.Part2.Personnel.Person Source { get; set; }
    }
}