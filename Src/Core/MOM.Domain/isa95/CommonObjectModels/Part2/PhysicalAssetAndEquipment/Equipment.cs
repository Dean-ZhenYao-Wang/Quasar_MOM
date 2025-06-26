namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.Equipment;
    using MOM.Domain.isa95.CommonObjectModels;
    using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    /// <summary>
    /// �豸
    /// </summary>
    /// <remarks>
    /// <para>ISA-95.00.01��׼���豸�㼶ģ�͵�Ԫ��Ӧ��ʾΪ�豸��</para>
    /// <para>�豸�����������κβ㼶��ʵ������ҵ�����������򡢹������ġ�������Ԫ������Ԫ����Ԫ�������ߡ�������Ԫ��������Ԫ���洢����ʹ洢��Ԫ</para>
    /// </remarks>
    public partial class Equipment : Resource, IEquatable<Equipment>
    {
        public Equipment() { }
        /// <summary>
        /// �豸�㼶
        /// </summary>
        /// <remarks>
        /// ���ڽ�ɫ���豸�㼶�еļ����ʶ
        /// </remarks>
        [Required]
        public EquipmentEquipmentLevel EquipmentLevel { get; set; }

        /// <summary>
        /// �����豸���嵥
        /// <para>���豸֧�ֵ��豸���</para>
        /// </summary>
        /// <remarks>
        /// ��ϵ���ͣ�����
        /// </remarks>
        [JsonIgnore]
        public virtual List<EquipmentDefinedByRelationship> DefinedBy { get; set; } = new List<EquipmentDefinedByRelationship>();

        /// <summary>
        /// ���豸������ֵ
        /// </summary>
        public virtual EquipmentProperty Property { get; set; } = new EquipmentProperty();

        /// <summary>
        /// ��ض�����Ϊ���幹�ɴ��豸��һ����
        /// <para>��ɹ�ϵ</para>
        /// </summary>
        [JsonIgnore]
        public virtual List<EquipmentIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentIsMadeUpOfRelationship>();

        /// <summary>
        /// ��Ӧ��ʵ���ʲ�<br/>
        /// ���豸�����̶��еĽ�ɫ�������ʲ�ʵ��
        /// </summary>
        /// <remarks>
        /// �����豸�ʲ�ӳ��
        /// </remarks>
        [JsonIgnore]
        public virtual EquipmentImplementedByRelationship ImplementedBy { get; set; }

        /// <summary>
        /// �豸�Ĳ�����Ϣ
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// �㼶��Χ
        /// </summary>
        /// <remarks>
        /// ��ʶ������Ϣ�ڻ��ڽ�ɫ���豸�㼶�е�λ�á���ѡ�أ��㼶��Χ�ɶ��������ʲ����ķ�Χ���綨���վ�������
        /// <para>��㼶�Ŀ�ѡ��ϵ</para>
        /// <para>�Ǳ�׼�淶Ҫ��</para>
        /// </remarks>
        public Guid? HierarchyScopeRelDtId { get; set; }

        /// <summary>
        /// �㼶��Χ
        /// </summary>
        /// <remarks>
        /// ��ʶ������Ϣ�ڻ��ڽ�ɫ���豸�㼶�е�λ�á���ѡ�أ��㼶��Χ�ɶ��������ʲ����ķ�Χ���綨���վ�������
        /// <para>��㼶�Ŀ�ѡ��ϵ</para>
        /// <para>�Ǳ�׼�淶Ҫ��</para>
        /// </remarks>
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }

        /// <summary>
        /// ����㼶��Χ
        /// </summary>
        /// <remarks>
        /// <para>��㼶�Ŀ�ѡ��ϵ</para>
        /// <para>�Ǳ�׼�淶Ҫ��</para>
        /// </remarks>
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }

        /// <summary>
        /// �ռ䶨��
        /// </summary>
        public SpatialDefinition? SpatialDefinition { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        [Required]
        public string Specification { get; set; }

        /// <summary>
        /// �ͺ�
        /// </summary>
        public string? ModelNumber { get; set; }

        /// <summary>
        /// ʹ����֯��DtId
        /// </summary>
        public Guid? UseOrgDtId { get; set; }

        /// <summary>
        /// ʹ����֯
        /// </summary>
        [JsonIgnore]
        [ForeignKey(nameof(UseOrgDtId))]
        public virtual PersonnelClass? UseOrg { get; set; }

        /// <summary>
        /// ʹ����֯
        /// </summary>
        public string? UseOrgName { get => UseOrg?.Id; }

        /// <summary>
        /// �豸״̬
        /// </summary>
        [Required]
        public EquipmentStatusType Status { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? EnabledTime { get; set; }

        /// <summary>
        /// ������DtId
        /// </summary>
        public Guid? ResponsibleDtId { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [JsonIgnore]
        [ForeignKey(nameof(ResponsibleDtId))]
        public virtual Person? Responsible { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string? ResponsibleName
        {
            get
            {
                return Responsible?.Name;
            }
        }

        /// <summary>
        /// ��Ӧ��
        /// </summary>
        [Required]
        public string Supplier { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        public string FactoryNumber { get; set; }

        /// <summary>
        /// �۾�����
        /// </summary>
        public int? DepreciationLife { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? FactoryDate { get; set; }

        /// <summary>
        /// ԭʼ�۸�
        /// </summary>
        public decimal? InitialPrice { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? DateOfPurchase { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public DateTime? WarrantyPeriod { get; set; }

        public Equipment(string ID,string name, string description, EquipmentEquipmentLevel EquipmentLevel)
        {
            this.Id = Id;
            this.Name = name;
            this.Description = description;
            this.EquipmentLevel = EquipmentLevel;
        }

        public Equipment(string ID,string name, string description, EquipmentEquipmentLevel equipmentLevel, string specification, string modelNumber, Guid? useOrgDtId, EquipmentStatusType status, DateTime? enabledTime, Guid? responsibleDtId, string supplier, string factoryNumber, int? depreciationLife, DateTime? factoryDate, decimal? initialPrice, DateTime? dateOfPurchase, DateTime? warrantyPeriod, SpatialDefinition? spatialDefinition) : this(ID,name, description, equipmentLevel)
        {
            Specification = specification;
            ModelNumber = modelNumber;
            UseOrgDtId = useOrgDtId;
            Status = status;
            EnabledTime = enabledTime;
            ResponsibleDtId = responsibleDtId;
            Supplier = supplier;
            FactoryNumber = factoryNumber;
            DepreciationLife = depreciationLife;
            FactoryDate = factoryDate;
            InitialPrice = initialPrice;
            DateOfPurchase = dateOfPurchase;
            this.WarrantyPeriod = warrantyPeriod;
            this.SpatialDefinition = spatialDefinition;
        }

        public void Delete()
        {
            this.IsMadeUpOf.Clear();
            this.IsDelete = true;
        }

        public void PutIsMadeUpOf(List<Guid> childDtId)
        {
            var haveDtIds = this.IsMadeUpOf.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childDtId);
            foreach (var item in deleteDtIds)
            {
                this.IsMadeUpOf.RemoveAll(m => m.TargetId == item);
            }
            foreach (var item in notHaveDtIds)
            {
                this.IsMadeUpOf.Add(new Common.Relationship.isa95.Equipment.EquipmentIsMadeUpOfRelationship(this.DtId, item));
            }
        }

        public void Update(string iD, string? description, EquipmentEquipmentLevel equipmentLevel)
        {
            this.Id = Id;
            this.Description = description ?? string.Empty;
            this.EquipmentLevel = equipmentLevel;
        }

        public void Update(string ID, string? description, EquipmentEquipmentLevel equipmentLevel, string specification, string modelNumber, Guid useOrgDtId, EquipmentStatusType status, DateTime? enabledTime, Guid responsibleDtId, string supplier, string factoryNumber, int depreciationLife, DateTime? factoryDate, decimal? initialPrice, DateTime? dateOfPurchase, DateTime? warrantyPeriod, SpatialDefinition? spatialDefinition)
        {
            this.Id = Id;
            this.Description = description ?? string.Empty;
            this.EquipmentLevel = equipmentLevel;
            this.Specification = specification;
            this.ModelNumber = modelNumber;
            this.UseOrgDtId = useOrgDtId;
            this.Status = status;
            this.EnabledTime = enabledTime;
            this.ResponsibleDtId = responsibleDtId;
            this.Supplier = supplier;
            this.FactoryNumber = factoryNumber;
            this.DepreciationLife = depreciationLife;
            this.FactoryDate = factoryDate;
            this.InitialPrice = initialPrice;
            this.DateOfPurchase = dateOfPurchase;
            this.WarrantyPeriod = warrantyPeriod;
            this.SpatialDefinition = spatialDefinition;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as Equipment);
        }

        /// <inheritdoc/>
        public bool Equals(Equipment? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && EquipmentLevel == other.EquipmentLevel;
        }

        /// <inheritdoc/>
        public static bool operator ==(Equipment? left, Equipment? right)
        {
            return EqualityComparer<Equipment?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(Equipment? left, Equipment? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), EquipmentLevel.GetHashCode());
        }
    }
}