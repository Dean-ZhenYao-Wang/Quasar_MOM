using MOM.Domain.Common.EnumType;
using System.ComponentModel.DataAnnotations;

namespace MOM.Application.DTOs.CodingRule.Requests
{
    /// <summary>
    /// 编码规则段
    /// </summary>
    public class CodingSegmentRequest
    {
        /// <summary>
        /// 编号
        /// 对象ID仅仅用于在相关的交换信息集中确认该对象。对象ID属性不是全局的对象ID，也不是数据库索引属性。
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// 段的排序顺序
        /// 用于确定该段在最终编码中的位置，从0开始
        /// 生成编码时会按此顺序依次处理各个段
        /// </summary>
        [Required]
        public int Order { get; set; }

        /// <summary>
        /// 段的类型
        /// 决定该段的值如何生成，参见SegmentType枚举的详细说明
        /// </summary>
        [Required]
        public CodingRuleSegmentType Type { get; set; }

        /// <summary>
        /// 段的值或配置参数
        /// 根据Type的不同，该字段的含义不同：
        /// - Fixed: 固定的字符串值
        /// - Property: EF Core模型中的属性名称
        /// - Sequence: 序列的名称标识（可选，默认为"default"）
        /// - DateTime: 预留字段，主要使用Format字段
        /// - Custom: 自定义逻辑的标识符或参数
        /// </summary>
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// 格式化字符串
        /// 用于格式化段的值，支持以下场景：
        /// - Property类型：当属性值实现IFormattable接口时使用（如DateTime、数字等）
        /// - DateTime类型：日期时间格式，如"yyyyMMdd"、"HHmmss"、"yyyy-MM-dd"等
        /// - 其他类型：预留扩展使用
        /// </summary>
        public string Format { get; set; } = string.Empty;

        /// <summary>
        /// 段的固定长度
        /// 当值为0时不限制长度
        /// 当值大于0时：
        /// - 如果实际值长度超过此值，会被截断
        /// - 如果实际值长度不足此值，会使用PaddingChar进行填充
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// 填充字符
        /// 当实际值长度小于Length时，使用此字符进行填充
        /// 默认为'0'，常用于序列号的前导零填充
        /// </summary>
        public char PaddingChar { get; set; } = '0';

        /// <summary>
        /// 填充方向
        /// true: 左填充（在值的左侧添加填充字符）- 适用于数字序列号
        /// false: 右填充（在值的右侧添加填充字符）- 适用于字符串值
        /// 默认为true（左填充）
        /// </summary>
        public bool PadLeft { get; set; } = true;
    }
}