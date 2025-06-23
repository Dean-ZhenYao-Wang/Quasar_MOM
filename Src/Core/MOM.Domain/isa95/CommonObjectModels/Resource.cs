namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 资源
    /// </summary>
    /// <remarks>
    /// 所有资源模型的抽象基类（包括人员、设备、物理资产、物料定义、物料批次、物料子批、工作指令、过程段、操作定义、操作位置、操作段、测试规范、测试结果）
    /// </remarks>
    public abstract class Resource : BaseEntity, IEquatable<Resource>
    {
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as Resource);
        }

        /// <inheritdoc/>
        public bool Equals(Resource? other)
        {
            return other is not null && base.Equals(other);
        }

        /// <inheritdoc/>
        public static bool operator ==(Resource? left, Resource? right)
        {
            return EqualityComparer<Resource?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(Resource? left, Resource? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}