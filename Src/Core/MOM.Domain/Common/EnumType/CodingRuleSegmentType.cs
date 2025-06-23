namespace MOM.Domain.Common.EnumType
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// 编码段类型枚举
    /// 定义编码规则中每个段的数据来源类型
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CodingRuleSegmentType
    {
        /// <summary>
        /// 固定值段
        /// 该段的值是预先设定的固定字符串，不会变化
        /// 例如：编码前缀 "PRD"、"ORD" 等
        /// </summary>
        [EnumMember(Value = "Fixed"), Display(Name = "固定值")]
        Fixed,

        /// <summary>
        /// 模型属性段
        /// 该段的值来源于EF Core模型的某个属性
        /// 例如：产品类别、客户代码等
        /// </summary>
        [EnumMember(Value = "Property"), Display(Name = "模型属性")]
        Property,

        /// <summary>
        /// 序列号段
        /// 该段的值是自动递增的序列号
        /// 支持多个独立的序列，每个序列可以有不同的名称和起始值
        /// </summary>
        [EnumMember(Value = "Sequence"), Display(Name = "序列号")]
        Sequence,

        /// <summary>
        /// 日期时间段
        /// 该段的值基于当前日期时间生成
        /// 支持自定义日期时间格式，如 "yyyyMMdd"、"HHmmss" 等
        /// </summary>
        [EnumMember(Value = "DateTime"), Display(Name = "日期时间")]
        DateTime,

        /// <summary>
        /// 自定义逻辑段
        /// 该段的值通过自定义逻辑生成
        /// 可通过继承ICodingRuleManager并重写ProcessCustomSegment方法实现
        /// </summary>
        [EnumMember(Value = "Custom"), Display(Name = "自定义逻辑")]
        Custom
    }
}