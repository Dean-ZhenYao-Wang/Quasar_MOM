using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.PersonProperty
{
    public partial class PersonPropertyMapsToRelationship
    {
        [JsonIgnore]
        [ForeignKey(nameof(SourceId))]
        public virtual Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty Source { get; set; }
    }
}