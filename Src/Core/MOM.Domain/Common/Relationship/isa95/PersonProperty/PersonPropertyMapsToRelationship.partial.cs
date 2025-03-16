using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MOM.Domain.Common.Relationship.isa95.PersonProperty
{
    public partial class PersonPropertyMapsToRelationship
    {
        [JsonIgnore]
        [ForeignKey(nameof(SourceId))]
        public virtual Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty Source { get; set; }
    }
}
