using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using MOM.Domain.Permission;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.isa95.CommonObjectModels
{
    /// <summary>
    /// 设备角色层次结构，逻辑工厂结构
    /// </summary>
    [Table(nameof(HierarchyScope))]
    public partial class HierarchyScope
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        /// <summary>
        /// 负责人DtId
        /// </summary>
        public Guid? ResponsibleDtId { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [JsonIgnore]
        [ForeignKey(nameof(ResponsibleDtId))]
        public virtual Person Responsible { get; set; }

        public string? ResponsibleName
        {
            get
            {
                return Responsible?.Name;
            }
        }

        /// <summary>
        /// 激活--默认处于禁用状态。
        /// 禁用后，这将阻止跟踪和追溯、OEE 停机时间、SPC、设置和转换以及调度模块使用该区域及其下方的任何其他生产项目
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string? Address { get; set; }
        /// <summary>
        /// 权限清单
        /// </summary>
        public virtual ICollection<OrgPermission> Permissions { get; set; } = new List<OrgPermission>();

        public HierarchyScope(HierarchyScopeEquipmentLevel equipmentLevel, string Id, string name, string? address = null, bool active = false, string? description = null) : this()
        {
            EquipmentLevel = equipmentLevel;
            this.Id = Id;
            this.Name = name;
            Address = address;
            Description = description;
            Active = active;
        }

        public void Delete()
        {
            if (this.Contains.Any(st => st.Target.IsDelete == false))
            {
                throw new MethodAccessException("存在子级，无法删除，是否强制删除(强制删除时子级也将会被删除)。");
            }
            else
            {
                this.ForcedDeletion();
            }
        }

        public virtual void ForcedDeletion()
        {
            this.ForcedDeletionContainTargets();
            this.IsDelete = true;
            this.Contains.Clear();//todo 需要定时任务配合，因为这个clear只会删除关系表中的SourceId列的内容，并未删除整行，需要定时任务定时删除表中这种数据
        }

        public virtual void ForcedDeletionContainTargets()
        {
            foreach (var st in this.Contains.Where(m => m.Target.IsDelete == false))
            {
                st.Target.ForcedDeletion();
            }
        }

        public virtual void Update(HierarchyScope hierarchyScope)
        {
            this.Id = hierarchyScope.Id;
            this.Name = hierarchyScope.Name;
            this.Description = hierarchyScope.Description;
            this.Active = hierarchyScope.Active;
            this.EquipmentLevel = hierarchyScope.EquipmentLevel;
            this.EquipmentID = hierarchyScope.EquipmentID;
            this.ResponsibleDtId = hierarchyScope.ResponsibleDtId;
            this.Address = hierarchyScope.Address;
        }
    }
}