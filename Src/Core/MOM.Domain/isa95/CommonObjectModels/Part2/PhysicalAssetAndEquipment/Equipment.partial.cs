using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    public partial class Equipment
    {

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
        /// 使用部门的DtId
        /// </summary>
        [JsonPropertyName("useDepartmentDtId")]
        public string? UseDepartmentDtId { get; set; }
        /// <summary>
        /// 使用部门
        /// </summary>
        [JsonIgnore]
        [ForeignKey(nameof(UseDepartmentDtId))]
        public virtual PersonnelClass? UseDepartment { get; set; }
        /// <summary>
        /// 使用部门
        /// </summary>
        [JsonPropertyName("departmentName")]
        public string? UseDepartmentName { get => UseDepartment?.Id; }
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
        public string? ResponsibleDtId { get; set; }

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
        public Equipment(string ID, string description, EquipmentEquipmentLevel? equipmentLevel, string number, string specification, string modelNumber, string? useDepartmentDtId, EquipmentStatusType status, DateTime enabledTime, string? responsibleDtId, string supplier, string factoryNumber, int depreciationLife, DateTime? factoryDate, decimal? initialPrice, DateTime? dateOfPurchase, DateTime? warrantyPeriod, SpatialDefinition? spatialDefinition) : this(ID, description, equipmentLevel)
        {
            Number = number;
            Specification = specification;
            ModelNumber = modelNumber;
            UseDepartmentDtId = useDepartmentDtId;
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
            foreach (var item in HasValuesOf)
            {
                item.Target.Delete();
            }
            this.HierarchyScopeRel.Clear();
            this.IsMadeUpOf.Clear();
            this.HasValuesOf.Clear();
            this.IsDelete = true;
        }

        public void PutIsMadeUpOf(List<string> childDtId)
        {
            var haveDtIds = this.IsMadeUpOf.Select(m => m.TargetId).ToList();
            var notHaveDtIds = childDtId.Except(haveDtIds);
            var deleteDtIds = haveDtIds.Except(childDtId);
            foreach (var item in deleteDtIds)
            {
                this.IsMadeUpOf.Remove(item);
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
        public void Update(string ID, string description, EquipmentEquipmentLevel? equipmentLevel, string number, string specification, string modelNumber, string useDepartmentDtId, EquipmentStatusType status, DateTime enabledTime, string responsibleDtId, string supplier, string factoryNumber, int depreciationLife, DateTime? factoryDate, decimal? initialPrice, DateTime? dateOfPurchase, DateTime? warrantyPeriod, SpatialDefinition? spatialDefinition)
        {
            this.Id = Id;
            this.Description = description ?? string.Empty;
            this.EquipmentLevel = equipmentLevel;
            this.Number = number;
            this.Specification = specification;
            this.ModelNumber = modelNumber;
            this.UseDepartmentDtId = useDepartmentDtId;
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
    }
}