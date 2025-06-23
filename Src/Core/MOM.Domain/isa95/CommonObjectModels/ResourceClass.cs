namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// ��Դ��
    /// </summary>
    /// <remarks>
    /// ������Դ��ģ�ͣ���Ա�ࡢ�豸�ࡢ�����ʲ��ࡢ�����ࣩ�ĳ���ģ��
    /// </remarks>
    public abstract class ResourceClass : BaseEntity, IEquatable<ResourceClass>
    {
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceClass);
        }

        /// <inheritdoc/>
        public bool Equals(ResourceClass? other)
        {
            return other is not null && base.Equals(other);
        }

        /// <inheritdoc/>
        public static bool operator ==(ResourceClass? left, ResourceClass? right)
        {
            return EqualityComparer<ResourceClass?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(ResourceClass? left, ResourceClass? right)
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