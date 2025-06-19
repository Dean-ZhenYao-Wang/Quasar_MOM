namespace MOM.Domain.Common;

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

/// <summary>
/// 用于实现模型特定关系的抽象基类
/// </summary>
/// <typeparam name="TSource">父级，需要继承自BaseEntity</typeparam>
/// <typeparam name="TTarget">子级，需要继承自BaseEntity</typeparam>
public abstract class Relationship<TSource, TTarget> : BasicRelationship, IEquatable<BasicRelationship>
    where TSource : BaseEntity
    where TTarget : BaseEntity
{
    public Relationship() { }
    /// <inheritdoc/>
    public override string Name { get; set; } = "default";
    /// <summary>
    /// 获取或设置关系的目标对象
    /// </summary>
    [ForeignKey(nameof(TargetId))]
    public virtual TTarget Target { get; set; }
    /// <summary>
    /// 获取或设置关系的源对象
    /// </summary>
    [JsonIgnore]
    [ForeignKey(nameof(SourceId))]
    public virtual TSource Source { get; set; }

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
        Id = $"{source.Id}-{target.Id}";
    }

    /// <summary>
    /// 根据源数字孪生ID和目标数字孪生ID初始化关系属性
    /// </summary>
    /// <param name="sourceDtId">源数字孪生唯一标识符</param>
    /// <param name="targetDtId">目标数字孪生唯一标识符</param>
    public void InitializeFromTwins(Guid sourceDtId, Guid targetDtId)
    {
        SourceId = sourceDtId;
        TargetId = targetDtId;
        Id = $"{sourceDtId}-{targetDtId}";
    }
    /// <summary>
    /// 根据源数字孪生ID和目标数字孪生ID初始化关系属性
    /// </summary>
    /// <param name="sourceDtId">源数字孪生唯一标识符</param>
    /// <param name="targetDtId">目标数字孪生唯一标识符</param>
    /// <param name="depth">深度</param>
    public void InitializeFromTwins(Guid sourceDtId, Guid targetDtId,int depth)
    {
        SourceId = sourceDtId;
        TargetId = targetDtId;
        Id = $"{sourceDtId}-{targetDtId}";
        Depth = depth;
    }

    /// <summary>
    /// 根据源数字孪生和目标数字孪生初始化关系属性
    /// </summary>
    /// <param name="source">作为关系来源的数字孪生</param>
    /// <param name="target">作为关系目标的数字孪生</param>
    public Relationship(TSource source, TTarget target)
    {
        InitializeFromTwins(source, target);
    }

    /// <summary>
    /// 根据源数字孪生ID和目标数字孪生ID初始化关系属性
    /// </summary>
    /// <param name="sourceId">源数字孪生唯一标识符</param>
    /// <param name="targetId">目标数字孪生唯一标识符</param>
    public Relationship(Guid sourceId, Guid targetId) 
    {
        InitializeFromTwins(sourceId, targetId);
    }
    /// <summary>
    /// 根据源数字孪生ID和目标数字孪生ID初始化关系属性
    /// </summary>
    /// <param name="sourceDtId">源数字孪生唯一标识符</param>
    /// <param name="targetDtId">目标数字孪生唯一标识符</param>
    /// <param name="depth">深度</param>
    public Relationship(Guid sourceId, Guid targetId, int depth) 
    {
        InitializeFromTwins(sourceId, targetId);
        this.Depth = depth;
    }
    /// <summary>
    /// 根据源数字孪生ID和目标数字孪生ID初始化关系属性
    /// </summary>
    /// <param name="sourceId">源数字孪生唯一标识符</param>
    /// <param name="target">目标数字孪生唯一标识符</param>
    /// <param name="depth">深度</param>
    public Relationship(Guid sourceId, TTarget target, int depth) : this(sourceId, target.DtId, depth)
    {
        this.Target = target;
    }
}