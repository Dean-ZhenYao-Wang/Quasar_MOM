using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MOM.Domain.Common.Relationship.isa95.Person
{
    public partial class PersonHasValuesOfRelationship
    {
        [JsonIgnore]
        [ForeignKey(nameof(SourceId))]
        public virtual Domain.isa95.CommonObjectModels.Part2.Personnel.Person Source { get; set; }
    }
}
