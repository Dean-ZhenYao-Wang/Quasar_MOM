// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace MOM.Domain.Common;

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

/// <summary>
/// 用于实现DTDL模型特定关系的抽象基类
/// </summary>
/// <typeparam name="TTarget">目标数字孪生类型，需继承自BaseEntity</typeparam>
//[NotMapped]
public abstract class Relationship<TTarget> : BasicRelationship, IEquatable<BasicRelationship>
    where TTarget : BaseEntity
{
    /// <summary>
    /// 获取或设置关系的目标数字孪生
    /// </summary>
    //[JsonIgnore]
    [ForeignKey(nameof(TargetId))]
    public virtual TTarget Target { get; set; }

    /// <inheritdoc/>
    public abstract bool Equals(BasicRelationship? other);

    /// <summary>
    /// 根据源数字孪生和目标数字孪生初始化关系属性
    /// </summary>
    /// <param name="source">作为关系来源的数字孪生</param>
    /// <param name="target">作为关系目标的数字孪生</param>
    protected void InitializeFromTwins(BaseEntity source, TTarget target)
    {
        SourceId = source.DtId;
        TargetId = target.DtId;
        Target = target;
    }

    /// <summary>
    /// 根据源数字孪生ID和目标数字孪生ID初始化关系属性
    /// </summary>
    /// <param name="sourceDtId">源数字孪生唯一标识符</param>
    /// <param name="targetDtId">目标数字孪生唯一标识符</param>
    protected void InitializeFromTwins(Guid sourceDtId, Guid targetDtId)
    {
        SourceId = sourceDtId;
        TargetId = targetDtId;
    }
}