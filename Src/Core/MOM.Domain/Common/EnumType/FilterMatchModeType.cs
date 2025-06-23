using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common.EnumType
{
    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FilterMatchModeType
    {
        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "startsWith"), Display(Name = "STARTS_WITH")]
        startsWith,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "contains"), Display(Name = "CONTAINS")]
        contains,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "notContains"), Display(Name = "NOT_CONTAINS")]
        notContains,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "endsWith"), Display(Name = "ENDS_WITH")]
        endsWith,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "equals"), Display(Name = "EQUALS")]
        equals,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "notEquals"), Display(Name = "NOT_EQUALS")]
        notEquals,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "IN"), Display(Name = "IN")]
        IN,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "lt"), Display(Name = "LESS_THAN")]
        lt,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "lte"), Display(Name = "LESS_THAN_OR_EQUAL_TO")]
        lte,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "gt"), Display(Name = "GREATER_THAN")]
        gt,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "gte"), Display(Name = "GREATER_THAN_OR_EQUAL_TO")]
        gte,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "between"), Display(Name = "BETWEEN")]
        between,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "dateIs"), Display(Name = "DATE_IS")]
        dateIs,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "dateIsNot"), Display(Name = "DATE_IS_NOT")]
        dateIsNot,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "dateBefore"), Display(Name = "DATE_BEFORE")]
        dateBefore,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "dateAfter"), Display(Name = "DATE_AFTER")]
        dateAfter
    }
}