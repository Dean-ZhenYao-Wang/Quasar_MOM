using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.Site
{
    public partial class SiteAreaRelationship
    {
        [JsonIgnore]
        [ForeignKey(nameof(SourceId))]
        public virtual MOM.Domain.isa95.EquipmentHierarchy.Site Source { get; set; }
    }
}