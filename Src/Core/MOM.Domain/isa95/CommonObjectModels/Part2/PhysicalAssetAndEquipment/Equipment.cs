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
        /// 所属设备类清单
        /// </summary>
        [JsonIgnore]
        public virtual List<EquipmentDefinedByRelationship> DefinedBy { get; set; } = new List<EquipmentDefinedByRelationship>();

        /// <summary>
        /// 扩展属性
        /// </summary>
        public virtual EquipmentProperty Property { get; set; } = new EquipmentProperty();

        /// <summary>
        /// 这个父设备是子设备的整体。<br/>
        /// 组成关系
        /// </summary>
        [JsonIgnore]
        public virtual List<EquipmentIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentIsMadeUpOfRelationship>();

        /// <summary>
        /// 对应的实物资产<br/>
        /// 该设备在工艺段中的作用是由实物资产实现的。
        /// </summary>
        [JsonIgnore]
        [MaxLength(1)]
        public virtual List<EquipmentImplementedByRelationship> ImplementedBy { get; set; } = new List<EquipmentImplementedByRelationship>();

        public Guid? HierarchyScopeRelDtId { get; set; }
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }
        /// <summary>
        /// 所属设备角色层次/所属组织
        /// </summary>
        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }



        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 空间定义
        /// </summary>
        public SpatialDefinition? SpatialDefinition { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [Required]
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [Required]
        [JsonPropertyName("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        [Required]
        [JsonPropertyName("modelNumber")]
        public string ModelNumber { get; set; }

        /// <summary>
        /// 使用组织的DtId
        /// </summary>
        [JsonPropertyName("useOrgDtId")]
        public Guid? UseOrgDtId { get; set; }

        /// <summary>
        /// 使用组织
        /// </summary>
        [JsonIgnore]
        [ForeignKey(nameof(UseOrgDtId))]
        public virtual PersonnelClass? UseOrg { get; set; }

        /// <summary>
        /// 使用组织
        /// </summary>
        [JsonPropertyName("OrgName")]
        public string? UseOrgName { get => UseOrg?.Id; }

        /// <summary>
        /// 设备状态
        /// </summary>
        [Required]
        [JsonPropertyName("status")]
        public EquipmentStatusType Status { get; set; }

        /// <summary>
        /// 启用时间
        /// </summary>
        [Required]
        [JsonPropertyName("enabledTime")]
        public DateTime EnabledTime { get; set; }

        /// <summary>
        /// 责任人DtId
        /// </summary>
        [JsonPropertyName("responsibleDtId")]
        public Guid? ResponsibleDtId { get; set; }

        /// <summary>
        /// 责任人
        /// </summary>
        [JsonIgnore]
        [ForeignKey(nameof(ResponsibleDtId))]
        public virtual Person? Responsible { get; set; }

        /// <summary>
        /// 责任人
        /// </summary>
        public string? ResponsibleName
        {
            get
            {
                return Responsible?.Name;
            }
        }

        /// <summary>
        /// 供应商
        /// </summary>
        [Required]
        [JsonPropertyName("supplier")]
        public string Supplier { get; set; }

        /// <summary>
        /// 出厂编号
        /// </summary>
        [Required]
        [JsonPropertyName("factoryNumber")]
        public string FactoryNumber { get; set; }

        /// <summary>
        /// 折旧年限
        /// </summary>
        [Required]
        [JsonPropertyName("depreciationLife")]
        public int DepreciationLife { get; set; }

        /// <summary>
        /// 出厂日期
        /// </summary>
        [JsonPropertyName("factoryDate")]
        public DateTime? FactoryDate { get; set; }

        /// <summary>
        /// 原始价格
        /// </summary>
        [JsonPropertyName("initialPrice")]
        public decimal? InitialPrice { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        [JsonPropertyName("dateOfPurchase")]
        public DateTime? DateOfPurchase { get; set; }

        /// <summary>
        /// 保修期
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