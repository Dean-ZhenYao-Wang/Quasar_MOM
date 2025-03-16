// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace MOM.Domain.Common;

using System.Collections.Generic;

internal class TwinEqualityComparer : IEqualityComparer<BaseEntity>
{
    /// <inheritdoc/>
    public bool Equals(BaseEntity? x, BaseEntity? y)
    {
        if (x == null && y == null)
        {
            return true;
        }

        if (x != null && y == null || x == null && y != null)
        {
            return false;
        }

        //if (x != null && y != null)
        //{
        //    var idAndMetadata = string.Equals(x?.ModelId, y?.ModelId) && string.Equals(x?.Id, y?.Id);
        //    if (x?.Contents != null && y?.Contents != null)
        //    {
        //        var contentsEquals = x.Contents.Count == y.Contents.Count && x.Contents.Except(y.Contents).Any();
        //        return idAndMetadata && contentsEquals;
        //    }

        //    return false;
        //}

        return false;
    }

    /// <inheritdoc/>
    public int GetHashCode(BaseEntity obj)
    {
#if NETSTANDARD2_1_OR_GREATER
        return HashCode.Combine(obj.Id);
#else
        return obj.DtId.GetHashCode();
#endif
    }
}