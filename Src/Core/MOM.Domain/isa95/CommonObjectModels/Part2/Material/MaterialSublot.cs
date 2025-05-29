namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialSublot;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialSublot : Resource, IEquatable<MaterialSublot>
    {
        public MaterialSublot()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialSublot;1";

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
        public MaterialSublotStorageLocationType? StorageLocationType { get; set; }

        /// <summary>
        /// ������װ����
        /// </summary>
        [JsonPropertyName("assemblyType")]
        public MaterialSublotAssemblyType? AssemblyType { get; set; }

        /// <summary>
        /// ������װ��ϵ������
        /// </summary>
        [JsonPropertyName("assemblyRelationship")]
        public MaterialSublotAssemblyRelationship? AssemblyRelationship { get; set; }

        /// <summary>
        /// ������������ҵ�е�״̬��ʵ�ֶ����ֵ
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// һ�����������λ�������������װ�ļƻ����������á�
        /// </summary>
        [JsonPropertyName("disposition")]
        public MaterialSublotDisposition? Disposition { get; set; }

        /// <summary>
        /// ���������ε�������
        /// </summary>
        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// ������Ķ�����λ
        /// </summary>
        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        /// <summary>
        /// �����ε������Σ�����ɹ�ϵ�����Ƿֽ��ϵ����ǰ�����α��ֽ�ɵ�ǰ������ָ����������嵥
        /// IsMadeUpOf �� IsAssembledFrom�Ķ��廹���ɣ�Ŀǰ����ȷ������Ӧ����ʲô����
        /// </summary>
        /// <remarks>This material sublot is part of the related object as the whole<br></br>�����������������ض�����Ϊ�����һ����</remarks>
        [JsonIgnore]
public virtual List<MaterialSublotIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<MaterialSublotIsMadeUpOfRelationship>();

        /// <summary>
        /// �����������ε���������������
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialSublotHasValuesOfRelationship> HasValuesOf { get; set; } = new List<MaterialSublotHasValuesOfRelationship>();

        /// <summary>
        /// ��ɵ�ǰ�����ε�������
        /// IsMadeUpOf �� IsAssembledFrom�Ķ��廹���ɣ�Ŀǰ����ȷ������Ӧ����ʲô����
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialSublotIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<MaterialSublotIsAssembledFromRelationship>();

        /// <summary>
        /// ��ɵ�ǰ�����ε�����
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialSublotIsAssembledFromLotRelationship> IsAssembledFromLot { get; set; } = new List<MaterialSublotIsAssembledFromLotRelationship>();

        /// <summary>
        /// �ʺϲ�νṹ��Χ
        /// </summary>
        /// <remarks>��ѡ�Ĳ�ι�ϵ�����Ǳ�׼����һ���֡�</remarks>
        [JsonIgnore]
public virtual List<MaterialSublotHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<MaterialSublotHierarchyScopeRelRelationship>();

        /// <summary>
        /// �ʺϴ�ŵص�
        /// </summary>
        /// <remarks>��洢λ�õĿ�ѡ��ϵ�����Ǳ�׼����һ���֡�</remarks>
        [JsonIgnore]
public virtual List<MaterialSublotStorageLocationRelRelationship> StorageLocationRel { get; set; } = new List<MaterialSublotStorageLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialSublot);
        }

        public bool Equals(MaterialSublot? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && StorageLocation == other.StorageLocation && StorageLocationType == other.StorageLocationType && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship && Status == other.Status && Disposition == other.Disposition && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(MaterialSublot? left, MaterialSublot? right)
        {
            return EqualityComparer<MaterialSublot?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialSublot? left, MaterialSublot? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), StorageLocation?.GetHashCode(), StorageLocationType?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode(), Status?.GetHashCode(), Disposition?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}