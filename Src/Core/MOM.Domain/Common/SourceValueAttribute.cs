// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace MOM.Domain.Common;

using System;

/// <summary>
/// 属性类用于保存附加的元数据，这些元数据可通过DTDL枚举属性获得。
/// </summary>
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public sealed class SourceValueAttribute : Attribute
{
    /// <summary>
    /// 获取或设置分配给属性的值。
    /// </summary>
    public string? Value { get; set; }
}