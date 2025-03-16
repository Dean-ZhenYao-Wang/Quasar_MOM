using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.EnumType
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FilterMatchModeType
    {
        [EnumMember(Value = "startsWith"), Display(Name = "STARTS_WITH")]
        startsWith,

        [EnumMember(Value = "contains"), Display(Name = "CONTAINS")]
        contains,

        [EnumMember(Value = "notContains"), Display(Name = "NOT_CONTAINS")]
        notContains,

        [EnumMember(Value = "endsWith"), Display(Name = "ENDS_WITH")]
        endsWith,

        [EnumMember(Value = "equals"), Display(Name = "EQUALS")]
        equals,

        [EnumMember(Value = "notEquals"), Display(Name = "NOT_EQUALS")]
        notEquals,

        [EnumMember(Value = "IN"), Display(Name = "IN")]
        IN,

        [EnumMember(Value = "lt"), Display(Name = "LESS_THAN")]
        lt,

        [EnumMember(Value = "lte"), Display(Name = "LESS_THAN_OR_EQUAL_TO")]
        lte,

        [EnumMember(Value = "gt"), Display(Name = "GREATER_THAN")]
        gt,

        [EnumMember(Value = "gte"), Display(Name = "GREATER_THAN_OR_EQUAL_TO")]
        gte,

        [EnumMember(Value = "between"), Display(Name = "BETWEEN")]
        between,

        [EnumMember(Value = "dateIs"), Display(Name = "DATE_IS")]
        dateIs,

        [EnumMember(Value = "dateIsNot"), Display(Name = "DATE_IS_NOT")]
        dateIsNot,

        [EnumMember(Value = "dateBefore"), Display(Name = "DATE_BEFORE")]
        dateBefore,

        [EnumMember(Value = "dateAfter"), Display(Name = "DATE_AFTER")]
        dateAfter
    }
}