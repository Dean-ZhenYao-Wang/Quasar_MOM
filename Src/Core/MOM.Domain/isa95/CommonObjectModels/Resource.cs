namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// ��Դ
    /// </summary>
    /// <remarks>
    /// ������Դģ�͵ĳ�����ࣨ������Ա���豸�������ʲ������϶��塢�������Ρ���������������ָ����̶Ρ��������塢����λ�á������Ρ����Թ淶�����Խ����
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