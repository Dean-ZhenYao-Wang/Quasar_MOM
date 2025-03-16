namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialLot;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialLot : Resource, IEquatable<MaterialLot>
    {
        public MaterialLot()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialLot;1";

        /// <summary>
        /// ��ʶ��������Ϣ�ڻ��ڽ�ɫ���豸��νṹ�е�λ�á�
        /// </summary>
        /// <remarks>��ѡ�أ�������������豸������������綨���豸���վ�������</remarks>
        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        /// <summary>
        /// ��ʶ�������εĴ��λ�á�
        /// </summary>
        [JsonPropertyName("storageLocation")]
        public string? StorageLocation { get; set; }

        /// <summary>
        /// ָʾ�洢λ��������ָ����λ�á��豸�������ʲ����󣬻��ǰ����洢λ�õ�������
        /// </summary>
        /// <remarks>ָ���洢λ��ʱ��ѡ</remarks>
        [JsonPropertyName("storageLocationType")]
        public MaterialLotStorageLocationType? StorageLocationType { get; set; }

        /// <summary>
        /// ������װ����
        /// </summary>
        [JsonPropertyName("assemblyType")]
        public MaterialLotAssemblyType? AssemblyType { get; set; }

        /// <summary>
        /// ������װ��ϵ������
        /// </summary>
        [JsonPropertyName("assemblyRelationship")]
        public MaterialLotAssemblyRelationship? AssemblyRelationship { get; set; }

        /// <summary>
        /// ������������ҵ�е�״̬��ʵ�ֶ����ֵ
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// һ���������λ�����������װ�ļƻ����������á�
        /// </summary>
        [JsonPropertyName("disposition")]
        public MaterialLotDisposition? Disposition { get; set; }

        /// <summary>
        /// �������ε�������
        /// </summary>
        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// ������Ķ�����λ
        /// </summary>
        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        /// <summary>
        /// ��ɵ�ǰ���ε�����
        /// </summary>
        /// <remarks>��Ϲ�ϵ<br></br>This material lot is part of the related object as the whole<br></br>����������Ϊ��������ض����һ����</remarks>
        [JsonIgnore]
        public virtual MaterialLotIsAssembledFromRelationshipCollection IsAssembledFrom { get; set; } = new MaterialLotIsAssembledFromRelationshipCollection();

        /// <summary>
        /// ���������ε�������������
        /// </summary>
        [JsonIgnore]
        public virtual MaterialLotHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new MaterialLotHasValuesOfRelationshipCollection();

        /// <summary>
        /// �����������ϵĲ��϶���
        /// </summary>
        [JsonIgnore]
        public virtual MaterialLotDefinedByRelationshipCollection DefinedBy { get; set; } = new MaterialLotDefinedByRelationshipCollection();

        /// <summary>
        /// ��ɵ�ǰ���ε�������
        /// </summary>
        /// <remarks>��Ϲ�ϵ<br></br>This material lot is part of the related object as the whole<br></br>����������Ϊ��������ض����һ����</remarks>
        [JsonIgnore]
        public virtual MaterialLotIsAssembledFromSublotRelationshipCollection IsAssembledFromSublot { get; set; } = new MaterialLotIsAssembledFromSublotRelationshipCollection();

        /// <summary>
        /// �ʺϲ�νṹ��Χ
        /// </summary>
        /// <remarks>��ѡ�Ĳ�ι�ϵ�����Ǳ�׼����һ���֡�</remarks>
        [JsonIgnore]
        public virtual MaterialLotHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new MaterialLotHierarchyScopeRelRelationshipCollection();

        /// <summary>
        /// �ʺϴ�ŵص�
        /// </summary>
        /// <remarks>��洢λ�õĿ�ѡ��ϵ�����Ǳ�׼����һ���֡�</remarks>
        [JsonIgnore]
        public virtual MaterialLotStorageLocationRelRelationshipCollection StorageLocationRel { get; set; } = new MaterialLotStorageLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialLot);
        }

        public bool Equals(MaterialLot? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && StorageLocation == other.StorageLocation && StorageLocationType == other.StorageLocationType && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship && Status == other.Status && Disposition == other.Disposition && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(MaterialLot? left, MaterialLot? right)
        {
            return EqualityComparer<MaterialLot?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialLot? left, MaterialLot? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), StorageLocation?.GetHashCode(), StorageLocationType?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode(), Status?.GetHashCode(), Disposition?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}