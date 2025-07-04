﻿namespace MOM.Application.DTOs.CodingRule.Requests
{
    /// <summary>
    /// 编码规则
    /// </summary>
    public class CodingRuleRequest
    {
        /// <summary>
        ///
        /// </summary>
        public Guid? DtId { get; set; }

        /// <summary>
        /// 编码规则的唯一标识符
        /// 用于在CodingRuleManager中注册和检索规则
        /// 建议使用有意义的命名，如"PRODUCT_RULE"、"ORDER_RULE"等
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 编码规则的显示名称
        /// 用于用户界面显示和日志记录
        /// 例如："产品编码规则"、"订单编码规则"等
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 编码规则的详细描述
        /// 可选字段，用于记录规则的用途、格式说明等详细信息
        /// 便于后续维护和理解规则的业务含义
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 目标EF Core模型类型
        /// 指定该编码规则适用于哪个实体模型
        /// 生成编码时会验证传入的模型对象是否匹配此类型
        /// </summary>
        public string ModelTypeName { get; set; } = string.Empty;

        /// <summary>
        /// 编码段之间的分隔符
        /// 用于连接各个编码段，形成最终的编码字符串
        /// 常用分隔符："-"、"_"、"."、""（空字符串表示无分隔符）
        /// 默认为"-"
        /// </summary>
        public string Separator { get; set; } = "-";

        /// <summary>
        /// 编码段配置列表
        /// 包含组成该编码规则的所有段配置
        /// 生成编码时会按段的Order属性顺序处理
        /// </summary>
        public List<CodingSegmentRequest> Segments { get; set; } = new List<CodingSegmentRequest>();

        /// <summary>
        /// 规则是否激活
        /// true: 规则可用，可以被用于生成编码
        /// false: 规则被禁用，GetRulesByModelType等方法会过滤掉此规则
        /// 默认为true
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        ///
        /// </summary>
        public Domain.CodingRule.CodingRule ToCodingRule()
        {
            Domain.CodingRule.CodingRule rule = new Domain.CodingRule.CodingRule
            {
                Id = Id,
                Name = Name,
                Description = Description,
                ModelTypeName = ModelTypeName,
                Separator = Separator,
                IsActive = IsActive
            };
            if (this.DtId.HasValue)
            {
                rule.DtId = this.DtId.Value;
            }
            if (Segments != null && Segments.Count > 0)
            {
                rule.Segments = Segments.Select(s => new Domain.CodingRule.CodingSegment
                {
                    RuleDtId = rule.DtId,
                    Id = rule.Id + "-" + s.Order,
                    Name = rule.Id + "-" + s.Order,
                    Order = s.Order,
                    Type = s.Type,
                    Value = s.Value,
                    Format = s.Format,
                    PaddingChar = s.PaddingChar,
                    Length = s.Length
                }).ToList();
            }
            return rule;
        }
    }
}