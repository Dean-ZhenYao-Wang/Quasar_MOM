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
    /// 设备
    /// </summary>
    /// <remarks>
    /// <para>ISA-95.00.01标准中设备层级模型的元素应表示为设备。</para>
    /// <para>设备可以是以下任何层级的实例：企业、厂区、区域、工作中心、工作单元、处理单元、单元、生产线、生产单元、工作单元、存储区域和存储单元</para>
    /// </remarks>
    public partial class Equipment : Resource, IEquatable<Equipment>
    {
        public Equipment() { }
        /// <summary>
        /// 设备层级
        /// </summary>
        /// <remarks>
        /// 基于角色的设备层级中的级别标识
        /// </remarks>
        [Required]
        public EquipmentEquipmentLevel EquipmentLevel { get; set; }

        /// <summary>
        /// 所属设备类清单
        /// <para>此设备支持的设备类别</para>
        /// </summary>
        /// <remarks>
        /// 关系类型：关联
        /// </remarks>
        [JsonIgnore]
        public virtual List<EquipmentDefinedByRelationship> DefinedBy { get; set; } = new List<EquipmentDefinedByRelationship>();

        /// <summary>
        /// 此设备的属性值
        /// </summary>
        public virtual EquipmentProperty Property { get; set; } = new EquipmentProperty();

        /// <summary>
        /// 相关对象作为整体构成此设备的一部分
        /// <para>组成关系</para>
        /// </summary>
        [JsonIgnore]
        public virtual List<EquipmentIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentIsMadeUpOfRelationship>();

        /// <summary>
        /// 对应的实物资产<br/>
        /// 此设备在流程段中的角色由物理资产实现
        /// </summary>
        /// <remarks>
        /// 用于设备资产映射
        /// </remarks>
        [JsonIgnore]
        public virtual EquipmentImplementedByRelationship ImplementedBy { get; set; }

        /// <summary>
        /// 设备的补充信息
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 层级范围
        /// </summary>
        /// <remarks>
        /// 标识交换信息在基于角色的设备层级中的位置。可选地，层级范围可定义物理资产类别的范围（如定义的站点或区域）
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        public Guid? HierarchyScopeRelDtId { get; set; }

        /// <summary>
        /// 层级范围
        /// </summary>
        /// <remarks>
        /// 标识交换信息在基于角色的设备层级中的位置。可选地，层级范围可定义物理资产类别的范围（如定义的站点或区域）
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.FullPath; } }

        /// <summary>
        /// 适配层级范围
        /// </summary>
        /// <remarks>
        /// <para>与层级的可选关系</para>
        /// <para>非标准规范要求</para>
        /// </remarks>
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }

        /// <summary>
        /// 空间定义
        /// </summary>
        public SpatialDefinition? SpatialDefinition { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [Required]
        public string Specification { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        public string? ModelNumber { get; set; }

        /// <summary>
        /// 使用组织的DtId
        /// </summary>
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
        public string? UseOrgName { get => UseOrg?.Id; }

        /// <summary>
        /// 设备状态
        /// </summary>
        [Required]
        public EquipmentStatusType Status { get; set; }

        /// <summary>
        /// 启用时间
        /// </summary>
        public DateTime? EnabledTime { get; set; }

        /// <summary>
        /// 责任人DtId
        /// </summary>
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
        public string Supplier { get; set; }

        /// <summary>
        /// 出厂编号
        /// </summary>
        [Required]
        public string FactoryNumber { get; set; }

        /// <summary>
        /// 折旧年限
        /// </summary>
        public int? DepreciationLife { get; set; }

        /// <summary>
        /// 出厂日期
        /// </summary>
        public DateTime? FactoryDate { get; set; }

        /// <summary>
        /// 原始价格
        /// </summary>
        public decimal? InitialPrice { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime? DateOfPurchase { get; set; }

        /// <summary>
        /// 保修期
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