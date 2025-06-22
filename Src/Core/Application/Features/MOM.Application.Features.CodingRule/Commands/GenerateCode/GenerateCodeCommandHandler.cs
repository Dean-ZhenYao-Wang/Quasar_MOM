using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.CodingRule;
using System.Data;

namespace MOM.Application.Features.CodingRule.Commands.GenerateCode
{
    /// <summary>
    /// 根据编码规则生成编码字符串
    /// 这是编码生成的核心方法，会按照规则配置的段顺序依次生成各段值
    /// </summary>
    public class GenerateCodeCommandHandler(ICodingRuleRepository codingRuleRepository, IUnitOfWork unitOfWork) : IRequestHandler<GenerateCodeCommand, string>
    {
        public async Task<string> Handle(GenerateCodeCommand request, CancellationToken cancellationToken)
        {
            var rule = await codingRuleRepository.GetRuleAsync(request.RuleId);
            if (rule == null) throw new ArgumentException($"未找到规则: {request.RuleId}");

            // 验证模型类型匹配（当model不为null时）
            if (!string.IsNullOrWhiteSpace(request.ModelTypeName))
            {
                Type model = Type.GetType(request.ModelTypeName);
                if (!rule.ModelType.IsAssignableFrom(model.GetType()))
                {
                    throw new ArgumentException($"模型类型不匹配，期望: {rule.ModelType.Name}，实际: {request.ModelTypeName.GetType().Name}");
                }
            }


            var segments = new List<string>();

            // 按Order顺序处理所有编码段
            foreach (var segment in rule.Segments.OrderBy(s => s.Order))
            {
                var segmentValue = await GenerateSegmentValueAsync(segment, request.DbModel, rule.ModelType);
                segments.Add(segmentValue);
            }

            // 使用分隔符连接所有段
            return string.Join(rule.Separator, segments);
        }
        /// <summary>
        /// 生成单个编码段的值
        /// 根据段的类型配置，从不同来源获取或生成段值
        /// </summary>
        /// <param name="segment">编码段配置</param>
        /// <param name="dbModel">从数据库查询出来的当前对象实例，仅在后端生成编码时使用，给谁生成编码，这个实例就是谁</param>
        /// <param name="modelType">模型类型</param>
        /// <returns>生成的段值字符串</returns>
        private async Task<string> GenerateSegmentValueAsync(MOM.Domain.CodingRule.CodingSegment segment, object? dbModel, Type modelType)
        {
            string value = "";

            switch (segment.Type)
            {
                case MOM.Domain.Common.EnumType.CodingRuleSegmentType.Fixed:
                    // 固定值段：直接使用配置的Value值
                    value = segment.Value ?? "";
                    break;

                case MOM.Domain.Common.EnumType.CodingRuleSegmentType.Property:
                    // 属性段：通过反射获取模型对象的属性值
                    if (dbModel != null && !string.IsNullOrEmpty(segment.Value))
                    {
                        var property = modelType.GetProperty(segment.Value);
                        var propVal = property?.GetValue(dbModel);
                        value = FormatValue(propVal, segment.Format);
                    }
                    break;

                case MOM.Domain.Common.EnumType.CodingRuleSegmentType.Sequence:
                    // 序列段：获取下一个序列号
                    value = (await codingRuleRepository.GetNextSequenceAsync(modelType, segment.Value ?? "default")).ToString();
                    break;

                case MOM.Domain.Common.EnumType.CodingRuleSegmentType.DateTime:
                    // 日期时间段：使用当前时间按指定格式生成
                    value = DateTime.Now.ToString(segment.Format ?? "yyyyMMdd");
                    break;

                case MOM.Domain.Common.EnumType.CodingRuleSegmentType.Custom:
                    // 自定义段：调用可重写的自定义处理方法
                    value = ProcessCustomSegment(segment, dbModel);
                    break;
            }

            // 应用长度限制和填充规则
            if (segment.Length > 0)
            {
                if (value.Length > segment.Length)//过长截断
                    value = value.Substring(0, segment.Length);
                else if (value.Length < segment.Length)//过短补充
                    value = segment.PadLeft
                        ? value.PadLeft(segment.Length, segment.PaddingChar)
                        : value.PadRight(segment.Length, segment.PaddingChar);
            }

            return value;
        }

        private string FormatValue(object value, string format)
        {
            return value switch
            {
                IFormattable formattable => formattable.ToString(format, null),
                _ => value?.ToString() ?? ""
            };
        }

        /// <summary>
        /// 处理自定义编码段
        /// 可重写以实现特定的自定义逻辑
        /// </summary>
        /// <param name="segment">自定义段配置</param>
        /// <param name="model">EF Core模型实例</param>
        /// <returns>自定义段的值，基类默认返回空字符串</returns>
        /// <remarks>
        /// 使用示例：
        /// - 可以根据segment.Value来区分不同的自定义逻辑
        /// - 可以使用model的属性值进行复杂计算
        /// - 可以集成外部系统获取特殊编码
        /// </remarks>
        protected string ProcessCustomSegment(CodingSegment segment, object model)
        {
            // 默认返回空字符串，子类可以重写实现自定义逻辑
            return "";
        }
    }
}
