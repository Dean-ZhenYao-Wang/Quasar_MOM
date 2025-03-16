// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace MOM.Domain.Common;

using System.Collections.Generic;

/// <summary>
/// 用于ADT基础关系的相等性比较器实现
/// </summary>
public class RelationshipEqualityComparer : IEqualityComparer<BasicRelationship>
{
    /// <inheritdoc/>
    public bool Equals(BasicRelationship? x, BasicRelationship? y)
    {
        if (x == null && y == null)
        {
            return true;
        }

        if (x != null && y == null || x == null && y != null)
        {
            return false;
        }

        if (x != null && y != null)
        {
            return x.DtId == y.DtId
                && x.Name == y.Name
                && x.SourceId == y.SourceId
                && x.TargetId == y.TargetId;
        }

        return false;
    }

    /// <inheritdoc/>
    public int GetHashCode(BasicRelationship obj)
    {
        return obj.DtId.GetHashCode();
    }
}