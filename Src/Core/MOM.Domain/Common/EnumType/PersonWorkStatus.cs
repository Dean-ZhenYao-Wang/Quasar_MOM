using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MOM.Domain.Common.EnumType
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PersonWorkStatus
    {
        [EnumMember(Value = "在职"), Display(Name = "在职")]
        在职,
        [EnumMember(Value = "休假"), Display(Name = "休假")]
        休假,
        [EnumMember(Value = "离职"), Display(Name = "离职")]
        离职
    }
}
