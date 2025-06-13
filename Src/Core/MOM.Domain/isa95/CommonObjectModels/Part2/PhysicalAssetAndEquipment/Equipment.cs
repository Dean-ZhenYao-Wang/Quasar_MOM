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

    public partial class Equipment : Resource, IEquatable<Equipment>
    {
        public Equipment()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:Equipment;1";

        [JsonPropertyName("equipmentLevel")]
        public EquipmentEquipmentLevel? EquipmentLevel { get; set; }

        /// <summary>
        /// �����豸���嵥
        /// </summary>
        [JsonIgnore]
        public virtual List<EquipmentDefinedByRelationship> DefinedBy { get; set; } = new List<EquipmentDefinedByRelationship>();

        /// <summary>
        /// ��չ����
        /// </summary>
        public virtual EquipmentProperty Property { get; set; } = new EquipmentProperty();

        /// <summary>
        /// ������豸�����豸�����塣<br/>
        /// ��ɹ�ϵ
        /// </summary>
        [JsonIgnore]
        public virtual List<EquipmentIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentIsMadeUpOfRelationship>();

        /// <summary>
        /// ��Ӧ��ʵ���ʲ�<br/>
        /// ���豸�ڹ��ն��е���������ʵ���ʲ�ʵ�ֵġ�
        /// </summary>
        [JsonIgnore]
        [MaxLength(1)]
        public virtual List<EquipmentImplementedByRelationship> ImplementedBy { get; set; } = new List<EquipmentImplementedByRelationship>();

        public Guid? HierarchyScopeRelDtId { get; set; }
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }
        /// <summary>
        /// �����豸��ɫ���/������֯
        /// </summary>
        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }



        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// �ռ䶨��
        /// </summary>
        public SpatialDefinition? SpatialDefinition { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        [Required]
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        [Required]
        [JsonPropertyName("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// �ͺ�
        /// </summary>
        [Required]
        [JsonPropertyName("modelNumber")]
        public string ModelNumber { get; set; }

        /// <summary>
        /// ʹ����֯��DtId
        /// </summary>
        [JsonPropertyName("useOrgDtId")]
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
        [JsonPropertyName("OrgName")]
        public string? UseOrgName { get => UseOrg?.Id; }

        /// <summary>
        /// �豸״̬
        /// </summary>
        [Required]
        [JsonPropertyName("status")]
        public EquipmentStatusType Status { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Required]
        [JsonPropertyName("enabledTime")]
        public DateTime EnabledTime { get; set; }

        /// <summary>
        /// ������DtId
        /// </summary>
        [JsonPropertyName("responsibleDtId")]
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
        [JsonPropertyName("supplier")]
        public string Supplier { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [JsonPropertyName("factoryNumber")]
        public string FactoryNumber { get; set; }

        /// <summary>
        /// �۾�����
        /// </summary>
        [Required]
        [JsonPropertyName("depreciationLife")]
        public int DepreciationLife { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [JsonPropertyName("factoryDate")]
        public DateTime? FactoryDate { get; set; }

        /// <summary>
        /// ԭʼ�۸�
        /// </summary>
        [JsonPropertyName("initialPrice")]
        public decimal? InitialPrice { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [JsonPropertyName("dateOfPurchase")]
        public DateTime? DateOfPurchase { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [JsonPropertyName("warrantyPeriod")]
        public DateTime? WarrantyPeriod { get; set; }

        public Equipment(string ID, string description, EquipmentEquipmentLevel? EquipmentLevel) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.EquipmentLevel = EquipmentLevel;
        }

        public Equipment(string ID, string description, EquipmentEquipmentLevel? equipmentLevel, string number, string specification, string modelNumber, Guid? useOrgDtId, EquipmentStatusType status, DateTime enabledTime, Guid? responsibleDtId, string supplier, string factoryNumber, int depreciationLife, DateTime? factoryDate, decimal? initialPrice, DateTime? dateOfPurchase, DateTime? warrantyPeriod, SpatialDefinition? spatialDefinition) : this(ID, description, equipmentLevel)
        {
            Number = number;
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

        public void Update(string iD, string? description, EquipmentEquipmentLevel? equipmentLevel)
        {
            this.Id = Id;
            this.Description = description ?? string.Empty;
            this.EquipmentLevel = equipmentLevel;
        }

        public void Update(string ID, string description, EquipmentEquipmentLevel? equipmentLevel, string number, string specification, string modelNumber, Guid useOrgDtId, EquipmentStatusType status, DateTime enabledTime, Guid responsibleDtId, string supplier, string factoryNumber, int depreciationLife, DateTime? factoryDate, decimal? initialPrice, DateTime? dateOfPurchase, DateTime? warrantyPeriod, SpatialDefinition? spatialDefinition)
        {
            this.Id = Id;
            this.Description = description ?? string.Empty;
            this.EquipmentLevel = equipmentLevel;
            this.Number = number;
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




        public override bool Equals(object? obj)
        {
            return Equals(obj as Equipment);
        }

        public bool Equals(Equipment? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && EquipmentLevel == other.EquipmentLevel;
        }

        public static bool operator ==(Equipment? left, Equipment? right)
        {
            return EqualityComparer<Equipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(Equipment? left, Equipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), EquipmentLevel?.GetHashCode());
        }

    }
}