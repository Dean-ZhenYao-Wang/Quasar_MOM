// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace MOM.Domain.Common;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

/// <summary>
/// 用于实现DTDL模型特定关系集合的抽象基类
/// </summary>
/// <typeparam name="TRelationship">DTDL模型的具体关系实现类型</typeparam>
/// <typeparam name="TTarget">关系目标类型（需继承自BaseEntity）</typeparam>
public abstract class RelationshipCollection<TRelationship, TTarget> : BasicRelationship, ICollection<TRelationship>
    where TRelationship : Relationship<TTarget>, new()
    where TTarget : BaseEntity
{
    private readonly ICollection<TRelationship> relationships = new List<TRelationship>();

    /// <summary>
    /// 初始化<see cref="RelationshipCollection{T, T}"/>类的新实例
    /// </summary>
    public RelationshipCollection()
    {
        Name = new TRelationship().Name;
    }

    /// <summary>
    /// 使用现有关系集合初始化<see cref="RelationshipCollection{T, T}"/>类的新实例
    /// </summary>
    /// <param name="relationships">用于初始化的关系集合</param>
    public RelationshipCollection(IEnumerable<TRelationship> relationships) : this()
    {
        this.relationships = new List<TRelationship>(relationships);
    }

    /// <summary>
    /// 获取当前关系集合中未被标记删除的目标数字孪生集合
    /// </summary>
    public ICollection<TTarget> Targets => (ICollection<TTarget>)relationships
        .Where(r => r.Target != null && r.Target.IsDelete == false)
        .Select(r => r.Target);

    /// <inheritdoc/>
    public int Count => Targets.Any() ? Targets.Where(m => m.IsDelete == false).Count() : 0;

    /// <inheritdoc/>
    public bool IsReadOnly => false;

    /// <summary>
    /// 添加单个关系到集合
    /// </summary>
    public void Add(TRelationship item)
    {
        relationships.Add(item);
    }

    /// <summary>
    /// 批量添加多个关系到集合
    /// </summary>
    public void AddRange(IEnumerable<TRelationship> items)
    {
        foreach (var item in items)
        {
            Add(item);
        }
    }

    /// <summary>
    /// 通过数字孪生ID创建并添加新关系
    /// </summary>
    /// <param name="sourceDtId">源数字孪生唯一标识符</param>
    /// <param name="targetDtId">目标数字孪生唯一标识符</param>
    public void Add(string sourceDtId, string targetDtId)
    {
        var item = new TRelationship();
        item.Name = Name;
        item.SourceId = sourceDtId;
        item.TargetId = targetDtId;
        item.DtId = $"{sourceDtId}-{Name}->{targetDtId}";
        relationships.Add(item);
    }

    /// <inheritdoc/>
    public void Clear()
    {
        relationships.Clear();
    }

    /// <inheritdoc/>
    public bool Contains(TRelationship item)
    {
        return relationships.Contains(item);
    }

    /// <inheritdoc/>
    public void CopyTo(TRelationship[] array, int arrayIndex)
    {
        relationships.CopyTo(array, arrayIndex);
    }

    /// <inheritdoc/>
    public IEnumerator<TRelationship> GetEnumerator() => relationships.GetEnumerator();

    /// <inheritdoc/>
    public bool Remove(TRelationship item)
    {
        return relationships.Remove(item);
    }

    /// <summary>
    /// 根据目标数字孪生ID移除关系
    /// </summary>
    /// <param name="dtId">目标数字孪生唯一标识符</param>
    public bool Remove(string dtId)
    {
        return relationships.Remove(relationships.First(m => m.TargetId.Equals(dtId)));
    }

    /// <summary>
    /// 批量根据目标数字孪生ID集合移除关系
    /// </summary>
    /// <param name="dtIds">目标数字孪生唯一标识符集合</param>
    public bool Remove(IEnumerable<string> dtIds)
    {
        foreach (string dtId in dtIds)
        {
            relationships.Remove(relationships.First(m => m.TargetId.Equals(dtId)));
        }
        return true;
    }

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => relationships.GetEnumerator();
}