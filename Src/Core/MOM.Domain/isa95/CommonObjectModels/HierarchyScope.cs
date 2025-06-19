namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    /// <summary>
    /// ��η�Χ
    /// </summary>
    /// <remarks>
    /// ��η�Χ��ʶ������Ϣ�ڻ��ڽ�ɫ���豸��νṹ�е�λ�á������彻����Ϣ�ķ�Χ����ISA-95��׼�е�վ������򣩣�����ʶ��ɫ�豸����еĹ���ʵ����
    /// </remarks>
    public partial class HierarchyScope : BaseEntity, IEquatable<MOM.Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        /// <summary>
        /// �豸ID
        /// </summary>
        public string? EquipmentID { get; set; }
        /// <summary>
        /// �豸�㼶
        /// </summary>
        /// <remarks>
        /// ���ڽ�ɫ���豸��νṹ�еĲ㼶��ʶ
        /// </remarks>
        public HierarchyScopeEquipmentLevel EquipmentLevel { get; set; }
        /// <summary>
        /// �������Ӽ�
        /// </summary>
        [JsonIgnore]
        public virtual List<HierarchyScopeContainsRelationship> Contains { get; set; } = new List<HierarchyScopeContainsRelationship>();
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as HierarchyScope);
        }

        /// <inheritdoc/>
        public bool Equals(HierarchyScope? other)
        {
            return other is not null && base.Equals(other) && EquipmentID == other.EquipmentID && EquipmentLevel == other.EquipmentLevel;
        }

        /// <inheritdoc/>
        public static bool operator ==(HierarchyScope? left, HierarchyScope? right)
        {
            return EqualityComparer<HierarchyScope?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(HierarchyScope? left, HierarchyScope? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), EquipmentID?.GetHashCode(), EquipmentLevel.GetHashCode());
        }
    }
}