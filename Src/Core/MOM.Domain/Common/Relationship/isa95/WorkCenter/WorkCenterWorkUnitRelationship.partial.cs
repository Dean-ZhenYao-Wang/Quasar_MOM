using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.Relationship.isa95.WorkCenter
{
    public partial class WorkCenterWorkUnitRelationship
    {
        [JsonIgnore]
        [ForeignKey(nameof(SourceId))]
        public virtual MOM.Domain.isa95.EquipmentHierarchy.WorkCenter Source { get; set; }
    }
}